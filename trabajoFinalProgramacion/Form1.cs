using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace trabajoFinalProgramacion
{

    
    public partial class Form1 : Form
    {

        public ListaCorredores lista = new ListaCorredores();
        public Form1()
        {
            InitializeComponent();

            dgv1.DataSource = lista.DT1;
            dgv2.DataSource = lista.DT2;
            dgv3.DataSource = lista.DT3;


        }

        

        //Acá declaro variables
        string nombre;
        string apellido;
        int edad;
        int DNI;
        bool carrera1;
        bool carrera2;
        bool carrera3;
        int numeroCarrera;

        //Acá creo los métodos de validación de datos
        public  void verficacionNombre(string nombre) {
            if (nombre == "")
            {
                lblAlertaNombre.Visible = true;
            }
            else
            {
                lblAlertaNombre.Visible = false;         
            }
        }

        public void verficacionApellido(string apellido)
        {
            if (apellido == "")
            {
                lblAlertaApellido.Visible = true;

            }
            else
            {
                lblAlertaApellido.Visible = false;

            }
        }


        public void verficacionEdad(int edad)
        {
            if (edad < 18)
            {
                lblAlertaEdadMayor.Visible = false;
                lblAlertaEdadMenor.Visible = true;
              
            }
            
            else if (edad > 55)
            {
                lblAlertaEdadMenor.Visible = false;
                lblAlertaEdadMayor.Visible = true;
                
            }
            else
            {
                lblAlertaEdadMayor.Visible = false;
                lblAlertaEdadMenor.Visible = false;
               
            }
        }


        public void verificacionDNI(int dni)
        {
            if (dni > 46000000 || dni < 18000000)
            {
                lblAlertaDNI.Visible = true;
                
            }
            else
            {
                lblAlertaDNI.Visible = false;
                
            }
        }

        public void verificacionCarrera(bool carrera1, bool carrera2, bool carrera3)
        {
            if ((carrera1 == false) && (carrera2 == false) && (carrera3 == false))
            {
                lblAlertaCarrera.Visible = true;
                
            }
            else
            {
                lblAlertaCarrera.Visible = false;
                
            }
        }

        //Acá le asigno un numero a la carrera elegida
        public int asignarNumeroCarrera(bool carrera1, bool carrera2, bool carrera3)
        {
            int carrera = 0;
            if (carrera1 == true)
            {
                carrera = 1;
            }
            else if (carrera2 == true)
            {
                carrera = 2;
            }
            else if (carrera3 == true)
            {
                carrera = 3;
            }
            return carrera;
        }

        //Acá creo el método para crear el objeto "corredorIngresado"
        public Corredor crearCorredor (string nombre,string apellido,int edad,int dni,int carrera)
        {
            Corredor corredorIngresado = new Corredor();
            corredorIngresado.nombreCorredor = nombre;
            corredorIngresado.apellidoCorredor = apellido;
            corredorIngresado.edadCorredor = edad;
            corredorIngresado.dniCorredor = DNI;
            corredorIngresado.carreraCorredor = numeroCarrera;

           return corredorIngresado;
            
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            

            lblAceptado.Visible = false;
            lblNoCupo.Visible = false;
            //btnCerrar.Visible = false;
            lblErrorDNIRepetido.Visible = false;

            //Acá asigno el valor correspondiente a las variables definidas previamente
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            edad = System.Convert.ToInt32(nmrEdad.Value);
            DNI = System.Convert.ToInt32(nmrDNI.Value);
            carrera1 = rdbtnCarrera5.Checked;
            carrera2 = rdbtnCarrera10.Checked;
            carrera3 = rdbtnCarreras15.Checked;
            numeroCarrera = asignarNumeroCarrera(carrera1, carrera2, carrera3);


            //Acá hago las validaciones
            verficacionNombre(nombre);
            verficacionApellido(apellido);
            verficacionEdad(edad);
            verificacionDNI(DNI);
            verificacionCarrera(carrera1, carrera2, carrera3);
            asignarNumeroCarrera(carrera1,carrera2,carrera3);
                        


            //Acá valido si está todo correcto y creo el objeto "corredorIngresado"
            if ((lblAlertaNombre.Visible == false) && (lblAlertaApellido.Visible == false) && (lblAlertaEdadMenor.Visible == false) && (lblAlertaEdadMayor.Visible == false) && (lblAlertaDNI.Visible == false) && (lblAlertaCarrera.Visible == false))
            {
                Corredor corredorActual = crearCorredor(nombre, apellido, edad, DNI, numeroCarrera);
                crearCorredor(nombre, apellido, edad, DNI, numeroCarrera);



                    //Muestro el mensaje de que la inscripcion se logro con exito
                    lblAceptado.Visible = true;

                    //Seteo todo en sus valores de default para ingresar un nuevo corredor
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    nmrEdad.Value = 18;
                    nmrDNI.Value = 0;
                    rdbtnCarrera5.Checked = false;
                    rdbtnCarrera10.Checked = false;
                    rdbtnCarreras15.Checked = false;

                    if (numeroCarrera == 1)
                    {
                        
                        lista.UpdateCorredor(corredorActual, 1);
                        
                    }
                    else if (numeroCarrera == 2)
                    {
                        lista.UpdateCorredor(corredorActual, 2);

                    }
                    else if (numeroCarrera == 3)
                    {
                        lista.UpdateCorredor(corredorActual, 3);
                    }

                
            }

           
        }

        private void btnMostrarInscriptos1_Click(object sender, EventArgs e)
        {

            lblAceptado.Visible = false;
            dgv1.Visible = true;
            dgv3.Visible = false;
            dgv2.Visible = false;
            btnCerrar.Visible = true;
        }

        private void btnMostrarInscriptos2_Click(object sender, EventArgs e)
        {

            lblAceptado.Visible = false;
            dgv2.Visible = true;
            dgv3.Visible = false;
            dgv1.Visible = false;
            btnCerrar.Visible = true;          

        }

        private void btnMostrarInscriptos3_Click(object sender, EventArgs e)
        {
            lblAceptado.Visible = false;
            dgv3.Visible = true;
            dgv2.Visible = false;
            dgv1.Visible = false;
            btnCerrar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            dgv2.Visible = false;
            dgv3.Visible = false;
            btnCerrar.Visible = false;
        }

    }


    public class Corredor
    {


        public string nombreCorredor; 
        public string apellidoCorredor; 
        public int edadCorredor; 
        public int dniCorredor; 
        public int carreraCorredor; 
    }


    public class ListaCorredores
    {
        public DataTable DT1 { get; set; } = new DataTable();
        public DataTable DT2 { get; set; } = new DataTable();
        public DataTable DT3 { get; set; } = new DataTable();

        public ListaCorredores()
        {
            DT1.TableName = "ListaCorredores1";
            DT1.Columns.Add("Nombre");
            DT1.Columns.Add("Apellido");
            DT1.Columns.Add("Edad");
            DT1.Columns.Add("DNI");

            DT2.TableName = "ListaCorredores2";
            DT2.Columns.Add("Nombre");
            DT2.Columns.Add("Apellido");
            DT2.Columns.Add("Edad");
            DT2.Columns.Add("DNI");

            DT3.TableName = "ListaCorredores3";
            DT3.Columns.Add("Nombre");
            DT3.Columns.Add("Apellido");
            DT3.Columns.Add("Edad");
            DT3.Columns.Add("DNI");

            LeerDT_DeArchivo(1);
            LeerDT_DeArchivo(2);
            LeerDT_DeArchivo(3);

        }

        public void LeerDT_DeArchivo( int numeroCarrera)
        {
     
            switch(numeroCarrera)
            {
                case 1:
                    {
                        if (File.Exists("Lista1.xml"))
                        {
                            DT1.Clear();
                            DT1.ReadXml("Lista1.xml");
                        }
                        break;
                    }
                case 2:
                    {
                        if (File.Exists("Lista2.xml"))
                        {
                            DT2.Clear();
                            DT2.ReadXml("Lista2.xml");
                        }
                        break;
                    }
                case 3:
                    {
                        if (File.Exists("Lista3.xml"))
                        {
                            DT3.Clear();
                            DT3.ReadXml("Lista3.xml");
                        }
                        break;
                    }
            }
        }

        public void UpdateCorredor(Corredor corredor,int numeroCarrera)
        {
            switch (numeroCarrera)
            {
                case 1:
                    {
                        DT1.Rows.Add();
                        int NumeroRegistroNuevo = DT1.Rows.Count - 1;

                        DT1.Rows[NumeroRegistroNuevo]["Nombre"] = corredor.nombreCorredor;
                        DT1.Rows[NumeroRegistroNuevo]["Apellido"] = corredor.apellidoCorredor;
                        DT1.Rows[NumeroRegistroNuevo]["Edad"] = corredor.edadCorredor.ToString();
                        DT1.Rows[NumeroRegistroNuevo]["DNI"] = corredor.dniCorredor.ToString();

                        DT1.WriteXml("Lista1.xml");
                        break;
                    }
                    
                case 2:
                    {
                        DT2.Rows.Add();
                        int NumeroRegistroNuevo = DT2.Rows.Count - 1;

                        DT2.Rows[NumeroRegistroNuevo]["Nombre"] = corredor.nombreCorredor;
                        DT2.Rows[NumeroRegistroNuevo]["Apellido"] = corredor.apellidoCorredor;
                        DT2.Rows[NumeroRegistroNuevo]["Edad"] = corredor.edadCorredor.ToString();
                        DT2.Rows[NumeroRegistroNuevo]["DNI"] = corredor.dniCorredor.ToString();

                        DT2.WriteXml("Lista2.xml");
                        break;
                    }

                case 3:
                    {
                        DT3.Rows.Add();
                        int NumeroRegistroNuevo = DT3.Rows.Count - 1;

                        DT3.Rows[NumeroRegistroNuevo]["Nombre"] = corredor.nombreCorredor;
                        DT3.Rows[NumeroRegistroNuevo]["Apellido"] = corredor.apellidoCorredor;
                        DT3.Rows[NumeroRegistroNuevo]["Edad"] = corredor.edadCorredor.ToString();
                        DT3.Rows[NumeroRegistroNuevo]["DNI"] = corredor.dniCorredor.ToString();

                        DT3.WriteXml("Lista3.xml");
                        break;
                    }
            }
        }

    }
}
