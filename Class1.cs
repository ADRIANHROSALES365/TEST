using System;


public class Concurso
{
	private string nombre_concurso;
	private string encargo;
	private string dependecia;
	private string fecha;
	private string precio;
	private string status;

	public Concurso(string nombre_concurso , string encargo,string dependencia,string fecha,int precio,string status)
	{
		nombre_concurso = nombre_concurso;
		encargo = encargo;
		dependencia = dependencia;
		fecha = fecha;
		precio = precio;
		status = status;
	}

	public void insertar_concurso(string nombre_concurso, string encargo, string dependencia, string fecha, int precio, bool pagado)
	{
		//Hacer Query para insertar Concurso a la base de datos
	}
}
