
using Microsoft.Extensions.Configuration;
using Serilog;

var builder = new ConfigurationBuilder();
BuidConfig(builder);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Build())
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();

Log.Logger.Information("Logging Process has Started....");

//Log.Logger = new LoggerConfiguration().CreateLogger();


static void BuidConfig(IConfigurationBuilder builder)
{
    //we are providing the ability to the Builder to talk to Appsettings.json
    //atayath nammal parayuaan ee directory il ulla "appsetings.json" enn perulla settings file ine add cheyuka nammade builder ilot
    //and nammal parayuaan that ee file add cheyunath Optional alla cheythe pattu and Json il change varuanel Reload cheyuka.

    builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
}
