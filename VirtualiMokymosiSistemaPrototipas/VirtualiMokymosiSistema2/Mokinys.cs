

using System;
/**
* @(#) Mokinys.cs
*/
namespace LogicalView
{
	public class Mokinys : Vartotojas
	{
		
		int tvarkarastis;

		
		String vardas;
		
		String pavarde;

		
		int uzduotiKlausimynai;
		
		
		String mokinioKodas;
		
		public Mokinys( String vardas, String pavarde,String slaptazodis,Mokykla mokykla ):base(vardas,pavarde,slaptazodis)
		{
			
		}
		
		public void pasirinktiKlausimuAtsakymus( Klausimynas klausimynas )
		{
			
		}
		
		public int gautiMokiniuiPriskirtuKlausimynuNumerius(  )
		{
			return 0;
		}
		
	}
	
}
