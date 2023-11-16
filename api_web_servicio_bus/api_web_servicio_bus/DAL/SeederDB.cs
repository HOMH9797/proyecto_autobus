namespace api_web_servicio_bus.DAL
{
    public class SeederDB
    {
        private readonly DataBaseContext _context;

        public SeederDB(DataBaseContext context)
        {
            _context = context;
        }
        public async Task SeederAsync()
        {
            //Primero: agregaré un método propio de EF que hace las veces del comando 'update-database'
            //En otras palabras: un método que me creará la BD inmediatamente ponga en ejecución mi API
            await _context.Database.EnsureCreatedAsync();

            //A partir de aquí vamos a ir creando métodos que me sirvan para prepoblar mi BD
            await PopulateUsuariosAsync();

            await _context.SaveChangesAsync(); //Esta línea me guarda ls datos en BD
        }
        private async Task PopulateUsuariosAsync()
        {
           
        }
    }
}
