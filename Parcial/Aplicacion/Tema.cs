namespace Aplicacion
{
    public static class Tema
    {
        private static List<string> temalist;

        private static System.Windows.Forms.DataGridViewCellStyle defaultGridCell;
        private static System.Windows.Forms.DataGridViewCellStyle defaultGridCell2;
        private static System.Windows.Forms.DataGridViewCellStyle darkGridCell;
        private static System.Windows.Forms.DataGridViewCellStyle darkGridCell2;
        private static System.Windows.Forms.DataGridViewCellStyle lightGridCell;
        private static System.Windows.Forms.DataGridViewCellStyle lightGridCell2;
        private static string temaEnUso;

        static Tema()
        {
            temalist = new List<string>();
            temaEnUso = "default";

            defaultGridCell = new System.Windows.Forms.DataGridViewCellStyle();
            defaultGridCell2 = new System.Windows.Forms.DataGridViewCellStyle();
            darkGridCell = new System.Windows.Forms.DataGridViewCellStyle();
            darkGridCell2 = new System.Windows.Forms.DataGridViewCellStyle();
            lightGridCell = new System.Windows.Forms.DataGridViewCellStyle();
            lightGridCell2 = new System.Windows.Forms.DataGridViewCellStyle();

            temalist.Add("Default");
            temalist.Add("Dark");
            temalist.Add("Light");

            defaultGridCell.BackColor = System.Drawing.Color.FromArgb(25, 33, 58);
            defaultGridCell.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            defaultGridCell2.BackColor = System.Drawing.Color.FromArgb(15, 23, 51);
            defaultGridCell2.ForeColor = defaultGridCell.ForeColor;

            darkGridCell.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            darkGridCell.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            darkGridCell2.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            darkGridCell2.ForeColor = darkGridCell.ForeColor;

            lightGridCell.BackColor = System.Drawing.Color.FromArgb(90, 100, 140);
            lightGridCell.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            lightGridCell2.BackColor = System.Drawing.Color.FromArgb(70, 80, 120);
            lightGridCell2.ForeColor = lightGridCell.ForeColor;

        }
        public static void SetTema(Panel? panel, DataGridView? dataGrid)
        {
            switch (temaEnUso)
            {
                case "Dark":
                    dataGrid!.RowsDefaultCellStyle.ForeColor = darkGridCell.ForeColor;
                    dataGrid!.AlternatingRowsDefaultCellStyle.ForeColor = darkGridCell2.ForeColor;
                    dataGrid!.RowsDefaultCellStyle.BackColor = darkGridCell.BackColor;
                    dataGrid!.AlternatingRowsDefaultCellStyle.BackColor = darkGridCell2.BackColor;
                    dataGrid!.ColumnHeadersDefaultCellStyle.ForeColor = darkGridCell2.ForeColor;
                    dataGrid!.ColumnHeadersDefaultCellStyle.BackColor = darkGridCell2.BackColor;
                    panel!.BackColor = darkGridCell.BackColor;
                    panel!.ForeColor = darkGridCell2.ForeColor;
                    break;
                case "Light":
                    dataGrid!.RowsDefaultCellStyle.ForeColor = lightGridCell.ForeColor;
                    dataGrid!.AlternatingRowsDefaultCellStyle.ForeColor = lightGridCell2.ForeColor;
                    dataGrid!.RowsDefaultCellStyle.BackColor = lightGridCell.BackColor;
                    dataGrid!.AlternatingRowsDefaultCellStyle.BackColor = lightGridCell2.BackColor;
                    dataGrid!.ColumnHeadersDefaultCellStyle.ForeColor = lightGridCell2.ForeColor;
                    dataGrid!.ColumnHeadersDefaultCellStyle.BackColor = lightGridCell2.BackColor;
                    panel!.BackColor = lightGridCell.BackColor;
                    panel!.ForeColor = lightGridCell2.ForeColor;
                    break;
                default:
                    dataGrid!.RowsDefaultCellStyle.ForeColor = defaultGridCell.ForeColor;
                    dataGrid!.AlternatingRowsDefaultCellStyle.ForeColor = defaultGridCell2.ForeColor;
                    dataGrid!.RowsDefaultCellStyle.BackColor = defaultGridCell.BackColor;
                    dataGrid!.AlternatingRowsDefaultCellStyle.BackColor = defaultGridCell2.BackColor;
                    dataGrid!.ColumnHeadersDefaultCellStyle.ForeColor = defaultGridCell2.ForeColor;
                    dataGrid!.ColumnHeadersDefaultCellStyle.BackColor = defaultGridCell2.BackColor;
                    panel!.BackColor = defaultGridCell.BackColor;
                    panel!.ForeColor = defaultGridCell2.ForeColor;
                    break;
            }
        }
        public static void SetTema(Panel? panel, DataGridView? dataGrid, string tema)
        {
            temaEnUso = tema;
            SetTema(panel, dataGrid);
        }
        public static void SetTema(Panel? panel)
        {
            switch (temaEnUso)
            {
                case "Dark":
                    panel!.BackColor = darkGridCell.BackColor;
                    panel!.ForeColor = darkGridCell2.ForeColor;
                    break;
                case "Light":
                    panel!.BackColor = lightGridCell.BackColor;
                    panel!.ForeColor = lightGridCell2.ForeColor;
                    break;
                default:
                    panel!.BackColor = defaultGridCell.BackColor;
                    panel!.ForeColor = defaultGridCell2.ForeColor;
                    break;
            }
        }
        public static List<string> GetLista()
        {
            return temalist;
        }
    }
}
