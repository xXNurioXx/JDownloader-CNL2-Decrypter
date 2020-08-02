﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace JDownloaderService
{
	public partial class Service : ServiceBase
	{
		private HttpServer WebHttpServer;
		public Service()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			WebHttpServer = new HttpServer();
			WebHttpServer.Start();
		}

		internal void onDebug()
		{
			OnStart(null);
		}

		protected override void OnStop()
		{
			WebHttpServer.Stop();
			WebHttpServer = null;
		}
	}
}