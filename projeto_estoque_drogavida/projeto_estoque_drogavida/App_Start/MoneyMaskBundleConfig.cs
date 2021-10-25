using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(projeto_estoque_drogavida.App_Start.MoneyMaskBundleConfig), "RegisterBundles")]

namespace projeto_estoque_drogavida.App_Start
{
	public class MoneyMaskBundleConfig
	{
		public static void RegisterBundles()
		{
			BundleTable.Bundles.Add(new ScriptBundle("~/bundles/moneymask").Include("~/Scripts/jquery.moneymask.js"));
		}
	}
}