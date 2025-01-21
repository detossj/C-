namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        Usuario usuario = new Usuario();
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBtnIngresarClicked(object sender, EventArgs e)
        {
            usuario.Rut = txtRut.Text;
            usuario.ApellidoPaterno = txtApellidoPaterno.Text;
            usuario.ApellidoMaterno = txtApellidoMaterno.Text;
            DateTime fecha = new DateTime(
                int.Parse(txtAnhio.Text),
                int.Parse(txtMes.Text),
                int.Parse(txtDia.Text)
                );
            usuario.Fecha = fecha;

        }

    }

}
