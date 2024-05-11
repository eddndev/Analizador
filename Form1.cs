using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Analizador
{
    public partial class Form1 : Form
    {
        List<string> palabrasReservadas = new List<string> {
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char",
            "checked", "class", "const", "continue", "decimal", "default", "delegate",
            "do", "double", "else", "enum", "event", "explicit", "extern", "false",
            "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit",
            "in", "int", "interface", "internal", "is", "lock", "long", "namespace",
            "new", "null", "object", "operator", "out", "override", "params",
            "private", "protected", "public", "readonly", "ref", "return", "sbyte",
            "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct",
            "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong",
            "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile",
            "while", "add", "alias", "ascending", "async", "await", "descending",
            "dynamic", "from", "get", "global", "group", "into", "join", "let",
            "orderby", "partial", "remove", "select", "set", "value", "var", "where",
            "yield"
        };
        public Form1()
        {
            InitializeComponent();
            foreach (DataGridViewTextBoxColumn column in dataViewCodigo.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataViewCodigo.RowHeadersVisible = false;
            dataViewCodigo.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataViewCodigo.AllowUserToResizeColumns = false;
            dataViewCodigo.AllowUserToResizeRows = false;
            dataViewCodigo.AllowUserToAddRows = false;
            dataViewCodigo.AllowUserToDeleteRows = false;
            dataViewCodigo.AllowUserToOrderColumns = false;
            // Lo mismo para el datagrid de errores
            foreach (DataGridViewTextBoxColumn column in dataViewErrores.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataViewErrores.RowHeadersVisible = false;
            dataViewErrores.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataViewErrores.AllowUserToResizeColumns = false;
            dataViewErrores.AllowUserToResizeRows = false;
            dataViewErrores.AllowUserToAddRows = false;
            dataViewErrores.AllowUserToDeleteRows = false;
            dataViewErrores.AllowUserToOrderColumns = false;
            //quitar user resizable
            
        }

        private void ArchivoBtn_Click(object sender, EventArgs e)
        {
            //Abre una ventana para buscar un archivo solamente con extension .java
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Java Files|*.java",
                Title = "Seleccione un archivo .java"
            };
            openFile.ShowDialog();
            //Si el archivo seleccionado es diferente de vacio
            if (openFile.FileName != "")
            {
                // Se limpian los datagrids
                dataViewCodigo.Rows.Clear();
                dataViewErrores.Rows.Clear();
                // Se agrega el archivo seleccionado al datagrid, numero de columna y linea
                string[] lines = System.IO.File.ReadAllLines(openFile.FileName);
                for (int i = 0; i < lines.Length; i++)
                {
                    dataViewCodigo.Rows.Add(i + 1, lines[i]);
                }
            }
        }
    }
}
