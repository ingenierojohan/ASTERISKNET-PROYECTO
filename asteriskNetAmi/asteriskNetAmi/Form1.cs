using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Asterisk.NET.Manager;
using Asterisk.NET.Manager.Event;
using System.Diagnostics;
using Asterisk.NET.Manager.Action;
using Asterisk.NET.Manager.Response;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private ManagerConnection asteriskManager = null;

        public Form1()
        {
            InitializeComponent();
        }

        void asteriskManager_Events(object sender, ManagerEvent e)
        {
            Debug.WriteLine("Event : " + e.GetType().Name);
        }

        private void connectToAsterisk()
        {
            try
            {
                // Conexion al Servidor Asterisk
                //asteriskManager = new ManagerConnection("192.168.10.200", 5038, "johan", "johan");  // Server Pruebas
                asteriskManager = new ManagerConnection("10.0.0.75", 5038, "ccempaques", "ccempaques"); // Server Empaques
                asteriskManager.UnhandledEvent += new ManagerEventHandler(asteriskManager_Events);

                // Login con --> Objeto astriskManager
                asteriskManager.Login();
            }
            // Conexion Falla
            catch (Exception ex)
            {
                MessageBox.Show("NO ME HE CONECTADO AL SERVIDOR ASTERISK.\n\n" + ex.ToString(),
                                "Error en la Conexion AMI",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                asteriskManager.Logoff();
                this.Close();
            }
        }


        private void llamar_Click(object sender, EventArgs e)
        {
            connectToAsterisk();
            registros.Clear();
            registros.Text = "--- Conexion Exitosa : ) --- " + Environment.NewLine; ;
            registros.Text += "** Generando LLAMADA **" + Environment.NewLine;
            //registros.Text += "Al Numero: " + telefono.Text + " Desde la Extension: " + extension.Text + Environment.NewLine;

            var originateAction = new OriginateAction();
            var originateResponse = new ManagerResponse();

            //originateAction.Channel = "Local/201@from-internal"; //Local/210@from-internal
            originateAction.Channel = "local/"+telefono.Text+"@from-internal"; //SIP/actionvoip/0085261234567,Ttr
            originateAction.CallerId = telefono.Text;
            originateAction.Context = "from-internal"; //from-internal,
            originateAction.Exten = extension.Text;
            //originateAction.Application = "Dial";
            //originateAction.Data = "SIP/210,201,Ttr"; //SIP/210,201,Ttr
            originateAction.Priority = 1;
            originateAction.Timeout = 30000;
            //originateAction.Async = true;

            // Realizando Login en el Servidor
            connectToAsterisk();

            

            registros.Text += "Llamado a Telefono: " + telefono.Text + Environment.NewLine;
            registros.Text += "Esperando a que Contesten: ";

            // Enviando Parametros para generar llamada, timbrara por 30 sg en el cliente, cuando contesten envia al agente
            originateResponse = asteriskManager.SendAction(originateAction, originateAction.Timeout);
            registros.Text += originateResponse.Response + Environment.NewLine;
            Debug.WriteLine(originateResponse.Response);
            registros.Text += "Llamando al Agente : " + extension.Text + Environment.NewLine;

            //  Desconectando del Servidor
            asteriskManager.Logoff();

        }
        
        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
