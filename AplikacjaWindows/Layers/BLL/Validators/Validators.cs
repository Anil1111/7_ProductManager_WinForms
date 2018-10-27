using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AplikacjaWindows.Layers.BLL.Validators
{
	// WALIDACJE
	public static class Validators
	{

		public static bool NameValidator(ErrorProvider eP, TextBox tB)
		{
			string errorMsg;

			if (string.IsNullOrEmpty(tB.Text))
			{
				errorMsg = "Nazwa jest wymagana.";
				eP.SetError(tB, errorMsg);
				return false;

			}

			if (tB.Text.Length > 255)
			{
				errorMsg = "Nazwa za długa. Maksymalnie 255 znaków.";
				eP.SetError(tB, errorMsg);
				return false;
			}

			eP.SetError(tB, "");
			return true;
		}

		public static bool CodeValidator(ErrorProvider eP, TextBox tB)
		{
			string errorMsg;
			string regexPatern = "^[0-9][0-9][0-9]-[0-9][0-9][0-9]$";

			if (string.IsNullOrEmpty(tB.Text))
			{
				errorMsg = "Kod jest wymagany";
				eP.SetError(tB, errorMsg);
				return false;
			}

			if (!Regex.IsMatch(tB.Text, regexPatern))
			{
				errorMsg = "Kod musi być w formacie XXX-XXX (X - liczby 0-9)";
				eP.SetError(tB, errorMsg);
				return false;
			}

			eP.SetError(tB, "");
			return true;
		}

		public static bool WeightValidator(ErrorProvider eP, TextBox tB)
		{
			string errorMsg;
			decimal d;

			if (string.IsNullOrEmpty(tB.Text))
			{
				errorMsg = "Masa jest wymagana";
				eP.SetError(tB, errorMsg);
				return false;
			}

			if (!decimal.TryParse(tB.Text, out d) || d < 0)
			{
				errorMsg = "Dopuszczalne liczby do dwóch miejsc po przecinku i wieksze/rowne 0";
				eP.SetError(tB, errorMsg);
				return false;
			}

			eP.SetError(tB, "");
			return true;
		}

		public static bool PriceValidator(ErrorProvider eP, TextBox tB)
		{
			string errorMsg;
			decimal d;

			if (string.IsNullOrEmpty(tB.Text))
			{
				errorMsg = "Cena jest wymagana";
				eP.SetError(tB, errorMsg);
				return false;
			}

			if (!decimal.TryParse(tB.Text, out d) || d > 0)
			{
				errorMsg = "Dopuszczalne liczby do dwóch miejsc po przecinku i wyższe niż 0";
				eP.SetError(tB, errorMsg);
				return false;
			}

			eP.SetError(tB, "");
			return true;
		}

		public static bool DiscountValidator(ErrorProvider eP, TextBox tB)
		{
			string errorMsg;
			decimal d;


			if (string.IsNullOrEmpty(tB.Text))
			{
				errorMsg = "Rabat jest wymagany";
				eP.SetError(tB, errorMsg);
				return false;
			}

			if (!decimal.TryParse(tB.Text, out d) || d < 0)
			{
				errorMsg = "Dopuszczalne liczby od 0 do 100";
				eP.SetError(tB, errorMsg);
				return false;
			}

			eP.SetError(tB, "");
			return true;
		}
	}
}
