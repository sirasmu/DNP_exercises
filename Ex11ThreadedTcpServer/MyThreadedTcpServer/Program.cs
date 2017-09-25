using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyThreadedTcpServer
{
   class Program
   {
      /*
      string fileName;
      public string data;
      public Reader( string fn ) { fileName = fn; }

      public void Read()
      {
         FileStream s = new FileStream(fileName, FileMode.Open);
         StreamReader r = new StreamReader(s);
         data = r.ReadToEnd();
         r.Close();
         s.Close();
      }

      public static void Main()
      {
         Reader r1 = new Reader(@"C:\OneDrive\one\ICT\VIA\semesters\sem4\DNP1\summer-autumn\DNP_exercises\Ex9Threading\MyOtherFiles\identical1.txt");
         Reader r2 = new Reader(@"C:\OneDrive\one\ICT\VIA\semesters\sem4\DNP1\summer-autumn\DNP_exercises\Ex9Threading\MyOtherFiles\identical2.txt");

         //add if r1 and r2 are not null
         Thread t0 = new Thread(r1.Read);
         Thread t1 = new Thread(r2.Read);
         t0.Start();
         t1.Start();

         #region //collapse visual studio thing
         t0.Join(); //wait until job is finished... also takes a timespan
         t1.Join(); //main thread is waiting for join
         #endregion
       */


      public void ClientServerCommunication()
      {
         //whatever you do when talking to a client
      }
      static void Main( string[] args )
      {
         bool isRunning = true;

         TcpListener serverTcpListener = new TcpListener(IPAddress.Any, 12345);
         serverTcpListener.Start();

         while( isRunning )
         {
            TcpClient newClient = serverTcpListener.AcceptTcpClient();

            // create a thread to handle communication
            Thread t = new Thread(new ParameterizedThreadStart(HandleClient));
            t.Start( newClient );
         }
      }

      private static void HandleClient( object obj )
      {
         TcpClient client = (TcpClient)obj;
         NetworkStream stream = client.GetStream();
         byte[] data = new byte[1024];
         int receive;

         while( true )
         {
            data = new byte[1024];
            try
            {
               receive = stream.Read( data, 0, data.Length );
            }
            catch( Exception )
            {
               break;
            }

            if( receive == 0 )
               break;

            Console.WriteLine( Encoding.ASCII.GetString( data, 0, receive ) );

            byte[] response = new byte[1024];
            response = Encoding.ASCII.GetBytes( "Your last message to the server was:" );
            stream.Write( response, 0, response.Length );

            stream.Write( data, 0, receive );
         }
         stream.Close();
         client.Close();
      }
   }
}
