using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GitTest2.Pages
{
    public class IndexModel : PageModel
    {

        private readonly string username = "myUsername";
        private readonly string password = "myPassword";
        string connectionString = "Data Source=localhost;Database=secretDatabase;Integrated Security=false;User ID=administrator;Password=secretpassword;";
        string azureConnectionString = "Server = tcp:myserver.database.windows.net,1433;Database=myDataBase;User ID = mylogin@myserver;Password=myPassword;Trusted_Connection=False;Encrypt=True;";

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}