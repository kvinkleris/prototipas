

using System;
/**
* @(#) Administratorius.cs
*/
namespace LogicalView
{
	public class Administratorius : Vartotojas
	{
		Mokykla mokyklos;
		
		String vardas;
		
		String pavarde;
		
		MokiniuGrupe mokiniuGrupes;
	
		
		public Administratorius( String s, String p, String pass )
            :base(s,p,pass)
		{
			
		}
		
		public void pridetiMokiniPrieGrupes( String grupesPavadinimas, String mokinioKodas )
		{
			
		}
		
		public MokiniuGrupe gautiMokiniuGrupes(  )
		{
			return null;
		}
		
		public void uzregistruotiNaujaMokiniuGrupe( String grupesPavadinimas )
		{
			
		}
		
		public MokiniuGrupe gautiMokiniuGrupe( String grupesPavadinimas )
		{
			return null;
		}
		
	}
	
}
