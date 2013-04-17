using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnSumaClicked (object sender, EventArgs e)
	{
		int numero1;
		int numero2;
		int resultado;

		numero1 = int.Parse (this.entry1.Text);
		numero2 = int.Parse (this.entry2.Text);
		resultado = numero1 + numero2;
		entry3.Text = resultado.ToString ();

	}

	protected void OnRestaClicked (object sender, EventArgs e)
	{
		int numero1;
		int numero2;
		int resultado;
		
		numero1 = int.Parse (this.entry1.Text);
		numero2 = int.Parse (this.entry2.Text);
		resultado = numero1 - numero2;
		entry3.Text = resultado.ToString ();

	}

	protected void OnMultiplicacionClicked (object sender, EventArgs e)
	{
		int numero1;
		int numero2;
		int resultado;
		
		numero1 = int.Parse (this.entry1.Text);
		numero2 = int.Parse (this.entry2.Text);
		resultado = numero1 * numero2;
		entry3.Text = resultado.ToString ();

	}

	protected void OnDivicionClicked (object sender, EventArgs e)
	{
		int numero1;
		int numero2;
		int resultado;
		
		numero1 = int.Parse (this.entry1.Text);
		numero2 = int.Parse (this.entry2.Text);
		resultado = numero1 / numero2;
		entry3.Text = resultado.ToString ();
	}
}
