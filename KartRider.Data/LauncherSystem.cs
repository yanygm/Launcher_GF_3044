﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartRider
{
	public static class LauncherSystem
	{
		public static void MessageBoxType1()
		{
			MessageBox.Show("跑跑卡丁车已经运行了，请重试！", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("KartRider");
			foreach (System.Diagnostics.Process p in process)
			{
				p.Kill();
			}
		}

		public static void MessageBoxType2()
		{
			MessageBox.Show("跑跑卡丁车已经运行了！", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		public static void MessageBoxType3()
		{
			MessageBox.Show(Launcher.KartRider + " 找不到文件！", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(1);
		}
	}
}