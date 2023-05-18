namespace ProjetCSharpMaintenance.Customs;

public static  class AppConstants
{
	public static string DB_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MaintenanceDB.db3");
	public static string DEFAUL_PSEUDO = "admin";
	public static string DEFAUL_PASSWORD = "admin";

	public static Utilisateur CurrentUser { get; set; } = null;

	public static string AppName { get; set; } = "Maintenance";


}
