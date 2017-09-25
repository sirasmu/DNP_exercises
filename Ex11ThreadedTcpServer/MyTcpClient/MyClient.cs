using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MyTcpClient
{
   public class MyClient
   {
      void MakeClient()
      {
         bool isRunning = true;
         byte[] data = new byte[1024];
         string input;
         string stringData;
         TcpClient client;

         try
         {
            client = new TcpClient( "127.0.0.1", 12345 );
         }
         catch( SocketException )
         {
            Console.WriteLine( "Unable to connect to server" );
            return;
         }


         NetworkStream stream = client.GetStream();

         Console.WriteLine( "Connected to server" );
         Console.WriteLine( "Type a message to the server or exit to stop" );

         while( isRunning )
         {
            input = Console.ReadLine();
            if( input == "exit" )
            {
               isRunning = false;
            }
            else
            {
               stream.Write( Encoding.ASCII.GetBytes( input ), 0, input.Length ); //we are using ascii.. ok makes sense
               stream.Flush(); //flushes data to stream????

               data = new byte[1024]; //why is the limit at 1024? well i guess that should be enough for most cases
               int receive = stream.Read(data, 0, data.Length); //we read from the stream from the server
               stringData = Encoding.ASCII.GetString( data, 0, receive ); // we encode the data and get a nice string from it
               Console.WriteLine( stringData );
            }
         }
         Console.WriteLine( "Disconnecting from server..." );
         stream.Close();
         client.Close();
      }
   }
}
