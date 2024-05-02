using  Microsoft.Office.Interop.Word;
namespace World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void worldtxt_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            try
            {
                // Crear un nuevo documento
                Document doc = wordApp.Documents.Add();

                // Obtener el texto de la TextBox
                string textToWrite = textBox1.Text;

                // Agregar el texto al documento
                doc.Content.Text = textToWrite;

                // Guardar el documento
                object fileName = @"D:\wvisual"; // Especifica la ruta donde deseas guardar el archivo
                doc.SaveAs2(ref fileName);

                // Cerrar el documento y la aplicación de Word
                doc.Close();
                wordApp.Quit();

                MessageBox.Show("Documento creado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el documento: " + ex.Message);
            }
            finally
            {
                // Liberar recursos
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
            }
        }
    }
}
