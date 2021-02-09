using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Messaging;
using System.IO;
using System.Drawing;

namespace NETMVCBlot.Controllers
{
    public class MSMQDeserializationController : Controller
    {
        public static string QUEUE_PATH = @".\private$\QueueName";

        public ActionResult Send()
        {
            return View();
        }

        public ActionResult Receive()
        {
			try
			{
				// Connect to the a queue on the local computer.
				MessageQueue myQueue = new MessageQueue(QUEUE_PATH);

				// Set the formatter to indicate body contains an Order.
				
				// CTSECISSUE:Insecure Deserialization - Binary
				myQueue.Formatter = new BinaryMessageFormatter();

				// Receive and format the message. 				
				System.Messaging.Message myMessage = myQueue.Receive();
				Bitmap myImage = (Bitmap)myMessage.Body;

				// This will be saved in the \bin\debug or \bin\retail folder.
				myImage.Save("ReceivedImage.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
			}

			catch (MessageQueueException)
			{
				// Handle Message Queuing exceptions.
			}
			// Handle invalid serialization format.
			catch (InvalidOperationException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (IOException e)
			{
				// Handle file access exceptions.
			}
			return View();
        }

    }
}