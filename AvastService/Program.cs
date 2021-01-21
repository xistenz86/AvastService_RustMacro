using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Macro
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1
		[DllImport("user32.dll")]
		public static extern bool GetAsyncKeyState(int key);

		// Token: 0x06000002 RID: 2
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern void mouse_event(int dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		private static void move(int x, int y, int sleep, int dwFlags = 1)
		{
			Program.mouse_event(dwFlags, x, y, 0U, 0U);
			Thread.Sleep(sleep);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002065 File Offset: 0x00000265
		private static void click()
		{
			Program.mouse_event(6, 0, 0, 0U, 0U);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002074 File Offset: 0x00000274
		private static void Main(string[] args)
		{
			Console.Title = "AvastService";
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("\n AK: NUMPAD 1 \n THOMPSON: NUMPAD 2 \n MP5: NUMPAD 3 \n BERDANKA: NUMPAD 4 \n SMG: NUMPAD 5 \n PYTHON: NUMPAD 6 \n TURN OFF ALL: NUMPAD 0");
			Thread thread = new Thread(new ThreadStart(Program.keyCheck));
			thread.Start();
			Thread thread2 = new Thread(new ThreadStart(Program.Macro));
			thread2.Start();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020D4 File Offset: 0x000002D4
		private static void keyCheck()
		{
			for (;;)
			{
				bool asyncKeyState = Program.GetAsyncKeyState(97);
				if (asyncKeyState)
				{
					Program.ak = !Program.ak;
					Console.WriteLine("AK macro is: " + Program.ak.ToString());
					bool flag = Program.ak;
					if (flag)
					{
						Program.thompson = false;
						Program.mp5 = false;
						Program.berdanka = false;
						Program.smg = false;
						Program.python = false;
						Console.Beep(400, 150);
					}
				}
				bool asyncKeyState2 = Program.GetAsyncKeyState(98);
				if (asyncKeyState2)
				{
					Program.thompson = !Program.thompson;
					Console.WriteLine("Thompson macro is: " + Program.thompson.ToString());
					bool flag2 = Program.thompson;
					if (flag2)
					{
						Program.ak = false;
						Program.mp5 = false;
						Program.berdanka = false;
						Program.smg = false;
						Program.python = false;
						Console.Beep(400, 150);
					}
				}
				bool asyncKeyState3 = Program.GetAsyncKeyState(99);
				if (asyncKeyState3)
				{
					Program.mp5 = !Program.mp5;
					Console.WriteLine("MP5 macro is: " + Program.mp5.ToString());
					bool flag3 = Program.mp5;
					if (flag3)
					{
						Program.ak = false;
						Program.thompson = false;
						Program.berdanka = false;
						Program.smg = false;
						Program.python = false;
						Console.Beep(400, 150);
					}
				}
				bool asyncKeyState4 = Program.GetAsyncKeyState(100);
				if (asyncKeyState4)
				{
					Program.berdanka = !Program.berdanka;
					Console.WriteLine("BERDANKA macro is: " + Program.berdanka.ToString());
					bool flag4 = Program.berdanka;
					if (flag4)
					{
						Program.ak = false;
						Program.thompson = false;
						Program.smg = false;
						Program.python = false;
						Program.mp5 = false;
						Console.Beep(400, 150);
					}
				}
				bool asyncKeyState5 = Program.GetAsyncKeyState(101);
				if (asyncKeyState5)
				{
					Program.smg = !Program.smg;
					Console.WriteLine("SMG macro is: " + Program.smg.ToString());
					bool flag5 = Program.smg;
					if (flag5)
					{
						Program.ak = false;
						Program.thompson = false;
						Program.python = false;
						Program.mp5 = false;
						Program.berdanka = false;
						Console.Beep(400, 150);
					}
				}
				bool asyncKeyState6 = Program.GetAsyncKeyState(102);
				if (asyncKeyState6)
				{
					Program.python = !Program.python;
					Console.WriteLine("Python macro is: " + Program.python.ToString());
					bool flag6 = Program.python;
					if (flag6)
					{
						Program.ak = false;
						Program.thompson = false;
						Program.mp5 = false;
						Program.berdanka = false;
						Program.smg = false;
						Console.Beep(400, 150);
					}
				}
				bool asyncKeyState7 = Program.GetAsyncKeyState(96);
				if (asyncKeyState7)
				{
					Console.WriteLine("Everything is now turned off");
					Program.ak = false;
					Program.thompson = false;
					Program.mp5 = false;
					Program.berdanka = false;
					Program.smg = false;
					Program.python = false;
					Console.Beep(400, 150);
				}
				Thread.Sleep(100);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000023E4 File Offset: 0x000005E4
		private static void Macro()
		{
			for (;;)
			{
				bool flag = Program.ak;
				if (flag)
				{
					bool asyncKeyState = Program.GetAsyncKeyState(1);
					if (asyncKeyState)
					{
						Program.move(-2, 3, 32, 1);
					}
					bool asyncKeyState2 = Program.GetAsyncKeyState(1);
					if (asyncKeyState2)
					{
						Program.move(-4, 6, 32, 1);
					}
					bool asyncKeyState3 = Program.GetAsyncKeyState(1);
					if (asyncKeyState3)
					{
						Program.move(-6, 9, 32, 1);
					}
					bool asyncKeyState4 = Program.GetAsyncKeyState(1);
					if (asyncKeyState4)
					{
						Program.move(-8, 12, 32, 1);
					}
					bool asyncKeyState5 = Program.GetAsyncKeyState(1);
					if (asyncKeyState5)
					{
						Program.move(0, 3, 32, 1);
					}
					bool asyncKeyState6 = Program.GetAsyncKeyState(1);
					if (asyncKeyState6)
					{
						Program.move(1, 6, 32, 1);
					}
					bool asyncKeyState7 = Program.GetAsyncKeyState(1);
					if (asyncKeyState7)
					{
						Program.move(2, 7, 32, 1);
					}
					bool asyncKeyState8 = Program.GetAsyncKeyState(1);
					if (asyncKeyState8)
					{
						Program.move(2, 10, 32, 1);
					}
					bool asyncKeyState9 = Program.GetAsyncKeyState(1);
					if (asyncKeyState9)
					{
						Program.move(-3, 3, 32, 1);
					}
					bool asyncKeyState10 = Program.GetAsyncKeyState(1);
					if (asyncKeyState10)
					{
						Program.move(-6, 5, 32, 1);
					}
					bool asyncKeyState11 = Program.GetAsyncKeyState(1);
					if (asyncKeyState11)
					{
						Program.move(-9, 7, 32, 1);
					}
					bool asyncKeyState12 = Program.GetAsyncKeyState(1);
					if (asyncKeyState12)
					{
						Program.move(-13, 10, 32, 1);
					}
					bool asyncKeyState13 = Program.GetAsyncKeyState(1);
					if (asyncKeyState13)
					{
						Program.move(-3, 3, 32, 1);
					}
					bool asyncKeyState14 = Program.GetAsyncKeyState(1);
					if (asyncKeyState14)
					{
						Program.move(-6, 4, 32, 1);
					}
					bool asyncKeyState15 = Program.GetAsyncKeyState(1);
					if (asyncKeyState15)
					{
						Program.move(-7, 7, 32, 1);
					}
					bool asyncKeyState16 = Program.GetAsyncKeyState(1);
					if (asyncKeyState16)
					{
						Program.move(-11, 8, 32, 1);
					}
					bool asyncKeyState17 = Program.GetAsyncKeyState(1);
					if (asyncKeyState17)
					{
						Program.move(0, 2, 32, 1);
					}
					bool asyncKeyState18 = Program.GetAsyncKeyState(1);
					if (asyncKeyState18)
					{
						Program.move(0, 5, 32, 1);
					}
					bool asyncKeyState19 = Program.GetAsyncKeyState(1);
					if (asyncKeyState19)
					{
						Program.move(0, 6, 32, 1);
					}
					bool asyncKeyState20 = Program.GetAsyncKeyState(1);
					if (asyncKeyState20)
					{
						Program.move(0, 8, 32, 1);
					}
					bool asyncKeyState21 = Program.GetAsyncKeyState(1);
					if (asyncKeyState21)
					{
						Program.move(1, 2, 32, 1);
					}
					bool asyncKeyState22 = Program.GetAsyncKeyState(1);
					if (asyncKeyState22)
					{
						Program.move(3, 4, 32, 1);
					}
					bool asyncKeyState23 = Program.GetAsyncKeyState(1);
					if (asyncKeyState23)
					{
						Program.move(3, 4, 32, 1);
					}
					bool asyncKeyState24 = Program.GetAsyncKeyState(1);
					if (asyncKeyState24)
					{
						Program.move(6, 6, 32, 1);
					}
					bool asyncKeyState25 = Program.GetAsyncKeyState(1);
					if (asyncKeyState25)
					{
						Program.move(2, 2, 32, 1);
					}
					bool asyncKeyState26 = Program.GetAsyncKeyState(1);
					if (asyncKeyState26)
					{
						Program.move(3, 3, 32, 1);
					}
					bool asyncKeyState27 = Program.GetAsyncKeyState(1);
					if (asyncKeyState27)
					{
						Program.move(5, 4, 32, 1);
					}
					bool asyncKeyState28 = Program.GetAsyncKeyState(1);
					if (asyncKeyState28)
					{
						Program.move(6, 4, 32, 1);
					}
					bool asyncKeyState29 = Program.GetAsyncKeyState(1);
					if (asyncKeyState29)
					{
						Program.move(3, 1, 32, 1);
					}
					bool asyncKeyState30 = Program.GetAsyncKeyState(1);
					if (asyncKeyState30)
					{
						Program.move(4, 2, 32, 1);
					}
					bool asyncKeyState31 = Program.GetAsyncKeyState(1);
					if (asyncKeyState31)
					{
						Program.move(6, 2, 32, 1);
					}
					bool asyncKeyState32 = Program.GetAsyncKeyState(1);
					if (asyncKeyState32)
					{
						Program.move(7, 3, 32, 1);
					}
					bool asyncKeyState33 = Program.GetAsyncKeyState(1);
					if (asyncKeyState33)
					{
						Program.move(3, 1, 32, 1);
					}
					bool asyncKeyState34 = Program.GetAsyncKeyState(1);
					if (asyncKeyState34)
					{
						Program.move(5, 2, 32, 1);
					}
					bool asyncKeyState35 = Program.GetAsyncKeyState(1);
					if (asyncKeyState35)
					{
						Program.move(7, 3, 32, 1);
					}
					bool asyncKeyState36 = Program.GetAsyncKeyState(1);
					if (asyncKeyState36)
					{
						Program.move(11, 4, 32, 1);
					}
					bool asyncKeyState37 = Program.GetAsyncKeyState(1);
					if (asyncKeyState37)
					{
						Program.move(3, 1, 32, 1);
					}
					bool asyncKeyState38 = Program.GetAsyncKeyState(1);
					if (asyncKeyState38)
					{
						Program.move(5, 2, 32, 1);
					}
					bool asyncKeyState39 = Program.GetAsyncKeyState(1);
					if (asyncKeyState39)
					{
						Program.move(7, 2, 32, 1);
					}
					bool asyncKeyState40 = Program.GetAsyncKeyState(1);
					if (asyncKeyState40)
					{
						Program.move(10, 3, 32, 1);
					}
					bool asyncKeyState41 = Program.GetAsyncKeyState(1);
					if (asyncKeyState41)
					{
						Program.move(2, 0, 32, 1);
					}
					bool asyncKeyState42 = Program.GetAsyncKeyState(1);
					if (asyncKeyState42)
					{
						Program.move(4, 0, 32, 1);
					}
					bool asyncKeyState43 = Program.GetAsyncKeyState(1);
					if (asyncKeyState43)
					{
						Program.move(6, 0, 32, 1);
					}
					bool asyncKeyState44 = Program.GetAsyncKeyState(1);
					if (asyncKeyState44)
					{
						Program.move(8, 0, 32, 1);
					}
					bool asyncKeyState45 = Program.GetAsyncKeyState(1);
					if (asyncKeyState45)
					{
						Program.move(2, 2, 32, 1);
					}
					bool asyncKeyState46 = Program.GetAsyncKeyState(1);
					if (asyncKeyState46)
					{
						Program.move(4, 4, 32, 1);
					}
					bool asyncKeyState47 = Program.GetAsyncKeyState(1);
					if (asyncKeyState47)
					{
						Program.move(6, 5, 32, 1);
					}
					bool asyncKeyState48 = Program.GetAsyncKeyState(1);
					if (asyncKeyState48)
					{
						Program.move(8, 6, 32, 1);
					}
					bool asyncKeyState49 = Program.GetAsyncKeyState(1);
					if (asyncKeyState49)
					{
						Program.move(2, 2, 32, 1);
					}
					bool asyncKeyState50 = Program.GetAsyncKeyState(1);
					if (asyncKeyState50)
					{
						Program.move(4, 3, 32, 1);
					}
					bool asyncKeyState51 = Program.GetAsyncKeyState(1);
					if (asyncKeyState51)
					{
						Program.move(4, 3, 32, 1);
					}
					bool asyncKeyState52 = Program.GetAsyncKeyState(1);
					if (asyncKeyState52)
					{
						Program.move(5, 3, 32, 1);
					}
					bool asyncKeyState53 = Program.GetAsyncKeyState(1);
					if (asyncKeyState53)
					{
						Program.move(0, 2, 32, 1);
					}
					bool asyncKeyState54 = Program.GetAsyncKeyState(1);
					if (asyncKeyState54)
					{
						Program.move(0, 4, 32, 1);
					}
					bool asyncKeyState55 = Program.GetAsyncKeyState(1);
					if (asyncKeyState55)
					{
						Program.move(0, 7, 32, 1);
					}
					bool asyncKeyState56 = Program.GetAsyncKeyState(1);
					if (asyncKeyState56)
					{
						Program.move(0, 10, 32, 1);
					}
					bool asyncKeyState57 = Program.GetAsyncKeyState(1);
					if (asyncKeyState57)
					{
						Program.move(-1, 2, 32, 1);
					}
					bool asyncKeyState58 = Program.GetAsyncKeyState(1);
					if (asyncKeyState58)
					{
						Program.move(-2, 2, 32, 1);
					}
					bool asyncKeyState59 = Program.GetAsyncKeyState(1);
					if (asyncKeyState59)
					{
						Program.move(-2, 2, 32, 1);
					}
					bool asyncKeyState60 = Program.GetAsyncKeyState(1);
					if (asyncKeyState60)
					{
						Program.move(-2, 4, 32, 1);
					}
					bool asyncKeyState61 = Program.GetAsyncKeyState(1);
					if (asyncKeyState61)
					{
						Program.move(-2, 3, 32, 1);
					}
					bool asyncKeyState62 = Program.GetAsyncKeyState(1);
					if (asyncKeyState62)
					{
						Program.move(-4, 5, 32, 1);
					}
					bool asyncKeyState63 = Program.GetAsyncKeyState(1);
					if (asyncKeyState63)
					{
						Program.move(-6, 6, 32, 1);
					}
					bool asyncKeyState64 = Program.GetAsyncKeyState(1);
					if (asyncKeyState64)
					{
						Program.move(-8, 8, 32, 1);
					}
					bool asyncKeyState65 = Program.GetAsyncKeyState(1);
					if (asyncKeyState65)
					{
						Program.move(-6, 7, 32, 1);
					}
					bool asyncKeyState66 = Program.GetAsyncKeyState(1);
					if (asyncKeyState66)
					{
						Program.move(-4, 5, 32, 1);
					}
					bool asyncKeyState67 = Program.GetAsyncKeyState(1);
					if (asyncKeyState67)
					{
						Program.move(-6, 6, 32, 1);
					}
					bool asyncKeyState68 = Program.GetAsyncKeyState(1);
					if (asyncKeyState68)
					{
						Program.move(-12, 8, 32, 1);
					}
					bool asyncKeyState69 = Program.GetAsyncKeyState(1);
					if (asyncKeyState69)
					{
						Program.move(-3, 2, 32, 1);
					}
					bool asyncKeyState70 = Program.GetAsyncKeyState(1);
					if (asyncKeyState70)
					{
						Program.move(-5, 4, 32, 1);
					}
					bool asyncKeyState71 = Program.GetAsyncKeyState(1);
					if (asyncKeyState71)
					{
						Program.move(-7, 6, 32, 1);
					}
					bool asyncKeyState72 = Program.GetAsyncKeyState(1);
					if (asyncKeyState72)
					{
						Program.move(-8, 7, 32, 1);
					}
					bool asyncKeyState73 = Program.GetAsyncKeyState(1);
					if (asyncKeyState73)
					{
						Program.move(-4, 2, 32, 1);
					}
					bool asyncKeyState74 = Program.GetAsyncKeyState(1);
					if (asyncKeyState74)
					{
						Program.move(-5, 3, 32, 1);
					}
					bool asyncKeyState75 = Program.GetAsyncKeyState(1);
					if (asyncKeyState75)
					{
						Program.move(-7, 4, 32, 1);
					}
					bool asyncKeyState76 = Program.GetAsyncKeyState(1);
					if (asyncKeyState76)
					{
						Program.move(-9, 5, 32, 1);
					}
					bool asyncKeyState77 = Program.GetAsyncKeyState(1);
					if (asyncKeyState77)
					{
						Program.move(-4, 2, 32, 1);
					}
					bool asyncKeyState78 = Program.GetAsyncKeyState(1);
					if (asyncKeyState78)
					{
						Program.move(-7, 2, 32, 1);
					}
					bool asyncKeyState79 = Program.GetAsyncKeyState(1);
					if (asyncKeyState79)
					{
						Program.move(-8, 4, 32, 1);
					}
					bool asyncKeyState80 = Program.GetAsyncKeyState(1);
					if (asyncKeyState80)
					{
						Program.move(-12, 4, 32, 1);
					}
					bool asyncKeyState81 = Program.GetAsyncKeyState(1);
					if (asyncKeyState81)
					{
						Program.move(-3, 0, 32, 1);
					}
					bool asyncKeyState82 = Program.GetAsyncKeyState(1);
					if (asyncKeyState82)
					{
						Program.move(-5, 1, 32, 1);
					}
					bool asyncKeyState83 = Program.GetAsyncKeyState(1);
					if (asyncKeyState83)
					{
						Program.move(-6, 1, 32, 1);
					}
					bool asyncKeyState84 = Program.GetAsyncKeyState(1);
					if (asyncKeyState84)
					{
						Program.move(-9, 2, 32, 1);
					}
					bool asyncKeyState85 = Program.GetAsyncKeyState(1);
					if (asyncKeyState85)
					{
						Program.move(-2, 0, 32, 1);
					}
					bool asyncKeyState86 = Program.GetAsyncKeyState(1);
					if (asyncKeyState86)
					{
						Program.move(-4, 0, 32, 1);
					}
					bool asyncKeyState87 = Program.GetAsyncKeyState(1);
					if (asyncKeyState87)
					{
						Program.move(-6, 0, 32, 1);
					}
					bool asyncKeyState88 = Program.GetAsyncKeyState(1);
					if (asyncKeyState88)
					{
						Program.move(-8, 0, 32, 1);
					}
					bool asyncKeyState89 = Program.GetAsyncKeyState(1);
					if (asyncKeyState89)
					{
						Program.move(-1, 1, 32, 1);
					}
					bool asyncKeyState90 = Program.GetAsyncKeyState(1);
					if (asyncKeyState90)
					{
						Program.move(-2, 2, 32, 1);
					}
					bool asyncKeyState91 = Program.GetAsyncKeyState(1);
					if (asyncKeyState91)
					{
						Program.move(-4, 3, 32, 1);
					}
					bool asyncKeyState92 = Program.GetAsyncKeyState(1);
					if (asyncKeyState92)
					{
						Program.move(-6, 6, 32, 1);
					}
					bool asyncKeyState93 = Program.GetAsyncKeyState(1);
					if (asyncKeyState93)
					{
						Program.move(-1, 1, 32, 1);
					}
					bool asyncKeyState94 = Program.GetAsyncKeyState(1);
					if (asyncKeyState94)
					{
						Program.move(-2, 2, 32, 1);
					}
					bool asyncKeyState95 = Program.GetAsyncKeyState(1);
					if (asyncKeyState95)
					{
						Program.move(-3, 3, 32, 1);
					}
					bool asyncKeyState96 = Program.GetAsyncKeyState(1);
					if (asyncKeyState96)
					{
						Program.move(-3, 4, 32, 1);
					}
					bool asyncKeyState97 = Program.GetAsyncKeyState(1);
					if (asyncKeyState97)
					{
						Program.move(1, 1, 32, 1);
					}
					bool asyncKeyState98 = Program.GetAsyncKeyState(1);
					if (asyncKeyState98)
					{
						Program.move(2, 3, 32, 1);
					}
					bool asyncKeyState99 = Program.GetAsyncKeyState(1);
					if (asyncKeyState99)
					{
						Program.move(2, 4, 32, 1);
					}
					bool asyncKeyState100 = Program.GetAsyncKeyState(1);
					if (asyncKeyState100)
					{
						Program.move(2, 6, 32, 1);
					}
					bool asyncKeyState101 = Program.GetAsyncKeyState(1);
					if (asyncKeyState101)
					{
						Program.move(3, 2, 32, 1);
					}
					bool asyncKeyState102 = Program.GetAsyncKeyState(1);
					if (asyncKeyState102)
					{
						Program.move(4, 2, 32, 1);
					}
					bool asyncKeyState103 = Program.GetAsyncKeyState(1);
					if (asyncKeyState103)
					{
						Program.move(6, 3, 32, 1);
					}
					bool asyncKeyState104 = Program.GetAsyncKeyState(1);
					if (asyncKeyState104)
					{
						Program.move(8, 3, 32, 1);
					}
					bool asyncKeyState105 = Program.GetAsyncKeyState(1);
					if (asyncKeyState105)
					{
						Program.move(4, 2, 32, 1);
					}
					bool asyncKeyState106 = Program.GetAsyncKeyState(1);
					if (asyncKeyState106)
					{
						Program.move(6, 4, 32, 1);
					}
					bool asyncKeyState107 = Program.GetAsyncKeyState(1);
					if (asyncKeyState107)
					{
						Program.move(10, 6, 32, 1);
					}
					bool asyncKeyState108 = Program.GetAsyncKeyState(1);
					if (asyncKeyState108)
					{
						Program.move(12, 8, 32, 1);
					}
					bool asyncKeyState109 = Program.GetAsyncKeyState(1);
					if (asyncKeyState109)
					{
						Program.move(3, 2, 32, 1);
					}
					bool asyncKeyState110 = Program.GetAsyncKeyState(1);
					if (asyncKeyState110)
					{
						Program.move(6, 4, 32, 1);
					}
					bool asyncKeyState111 = Program.GetAsyncKeyState(1);
					if (asyncKeyState111)
					{
						Program.move(9, 6, 32, 1);
					}
					bool asyncKeyState112 = Program.GetAsyncKeyState(1);
					if (asyncKeyState112)
					{
						Program.move(12, 8, 32, 1);
					}
					bool asyncKeyState113 = Program.GetAsyncKeyState(1);
					if (asyncKeyState113)
					{
						Program.move(3, 1, 32, 1);
					}
					bool asyncKeyState114 = Program.GetAsyncKeyState(1);
					if (asyncKeyState114)
					{
						Program.move(5, 2, 32, 1);
					}
					bool asyncKeyState115 = Program.GetAsyncKeyState(1);
					if (asyncKeyState115)
					{
						Program.move(12, 2, 32, 1);
					}
					bool asyncKeyState116 = Program.GetAsyncKeyState(1);
					if (asyncKeyState116)
					{
						Program.move(12, 2, 32, 1);
					}
					bool asyncKeyState117 = Program.GetAsyncKeyState(1);
					if (asyncKeyState117)
					{
						Program.move(2, 1, 32, 1);
					}
					bool asyncKeyState118 = Program.GetAsyncKeyState(1);
					if (asyncKeyState118)
					{
						Program.move(2, 3, 32, 1);
					}
					bool asyncKeyState119 = Program.GetAsyncKeyState(1);
					if (asyncKeyState119)
					{
						Program.move(3, 4, 32, 1);
					}
					bool asyncKeyState120 = Program.GetAsyncKeyState(1);
					if (asyncKeyState120)
					{
						Program.move(4, 6, 32, 1);
					}
				}
				bool flag2 = Program.thompson;
				if (flag2)
				{
					bool asyncKeyState121 = Program.GetAsyncKeyState(1);
					if (asyncKeyState121)
					{
						Program.move(0, 0, 80, 1);
					}
					bool asyncKeyState122 = Program.GetAsyncKeyState(1);
					if (asyncKeyState122)
					{
						Program.move(-8, 17, 20, 1);
					}
					bool asyncKeyState123 = Program.GetAsyncKeyState(1);
					if (asyncKeyState123)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState124 = Program.GetAsyncKeyState(1);
					if (asyncKeyState124)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState125 = Program.GetAsyncKeyState(1);
					if (asyncKeyState125)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState126 = Program.GetAsyncKeyState(1);
					if (asyncKeyState126)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState127 = Program.GetAsyncKeyState(1);
					if (asyncKeyState127)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState128 = Program.GetAsyncKeyState(1);
					if (asyncKeyState128)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState129 = Program.GetAsyncKeyState(1);
					if (asyncKeyState129)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState130 = Program.GetAsyncKeyState(1);
					if (asyncKeyState130)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState131 = Program.GetAsyncKeyState(1);
					if (asyncKeyState131)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState132 = Program.GetAsyncKeyState(1);
					if (asyncKeyState132)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState133 = Program.GetAsyncKeyState(1);
					if (asyncKeyState133)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState134 = Program.GetAsyncKeyState(1);
					if (asyncKeyState134)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState135 = Program.GetAsyncKeyState(1);
					if (asyncKeyState135)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState136 = Program.GetAsyncKeyState(1);
					if (asyncKeyState136)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState137 = Program.GetAsyncKeyState(1);
					if (asyncKeyState137)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState138 = Program.GetAsyncKeyState(1);
					if (asyncKeyState138)
					{
						Program.move(1, 2, 20, 1);
					}
					bool asyncKeyState139 = Program.GetAsyncKeyState(1);
					if (asyncKeyState139)
					{
						Program.move(1, 2, 20, 1);
					}
					bool asyncKeyState140 = Program.GetAsyncKeyState(1);
					if (asyncKeyState140)
					{
						Program.move(1, 2, 20, 1);
					}
					bool asyncKeyState141 = Program.GetAsyncKeyState(1);
					if (asyncKeyState141)
					{
						Program.move(1, 2, 20, 1);
					}
					bool asyncKeyState142 = Program.GetAsyncKeyState(1);
					if (asyncKeyState142)
					{
						Program.move(1, 2, 20, 1);
					}
					bool asyncKeyState143 = Program.GetAsyncKeyState(1);
					if (asyncKeyState143)
					{
						Program.move(1, 2, 20, 1);
					}
					bool asyncKeyState144 = Program.GetAsyncKeyState(1);
					if (asyncKeyState144)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState145 = Program.GetAsyncKeyState(1);
					if (asyncKeyState145)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState146 = Program.GetAsyncKeyState(1);
					if (asyncKeyState146)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState147 = Program.GetAsyncKeyState(1);
					if (asyncKeyState147)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState148 = Program.GetAsyncKeyState(1);
					if (asyncKeyState148)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState149 = Program.GetAsyncKeyState(1);
					if (asyncKeyState149)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState150 = Program.GetAsyncKeyState(1);
					if (asyncKeyState150)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState151 = Program.GetAsyncKeyState(1);
					if (asyncKeyState151)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState152 = Program.GetAsyncKeyState(1);
					if (asyncKeyState152)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState153 = Program.GetAsyncKeyState(1);
					if (asyncKeyState153)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState154 = Program.GetAsyncKeyState(1);
					if (asyncKeyState154)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState155 = Program.GetAsyncKeyState(1);
					if (asyncKeyState155)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState156 = Program.GetAsyncKeyState(1);
					if (asyncKeyState156)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState157 = Program.GetAsyncKeyState(1);
					if (asyncKeyState157)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState158 = Program.GetAsyncKeyState(1);
					if (asyncKeyState158)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState159 = Program.GetAsyncKeyState(1);
					if (asyncKeyState159)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState160 = Program.GetAsyncKeyState(1);
					if (asyncKeyState160)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState161 = Program.GetAsyncKeyState(1);
					if (asyncKeyState161)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState162 = Program.GetAsyncKeyState(1);
					if (asyncKeyState162)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState163 = Program.GetAsyncKeyState(1);
					if (asyncKeyState163)
					{
						Program.move(-1, 1, 20, 1);
					}
					bool asyncKeyState164 = Program.GetAsyncKeyState(1);
					if (asyncKeyState164)
					{
						Program.move(-1, 1, 20, 1);
					}
					bool asyncKeyState165 = Program.GetAsyncKeyState(1);
					if (asyncKeyState165)
					{
						Program.move(-1, 1, 20, 1);
					}
					bool asyncKeyState166 = Program.GetAsyncKeyState(1);
					if (asyncKeyState166)
					{
						Program.move(-1, 1, 20, 1);
					}
					bool asyncKeyState167 = Program.GetAsyncKeyState(1);
					if (asyncKeyState167)
					{
						Program.move(-1, 1, 20, 1);
					}
					bool asyncKeyState168 = Program.GetAsyncKeyState(1);
					if (asyncKeyState168)
					{
						Program.move(-1, 1, 20, 1);
					}
					bool asyncKeyState169 = Program.GetAsyncKeyState(1);
					if (asyncKeyState169)
					{
						Program.move(0, 1, 20, 1);
					}
					bool asyncKeyState170 = Program.GetAsyncKeyState(1);
					if (asyncKeyState170)
					{
						Program.move(0, 1, 20, 1);
					}
					bool asyncKeyState171 = Program.GetAsyncKeyState(1);
					if (asyncKeyState171)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState172 = Program.GetAsyncKeyState(1);
					if (asyncKeyState172)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState173 = Program.GetAsyncKeyState(1);
					if (asyncKeyState173)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState174 = Program.GetAsyncKeyState(1);
					if (asyncKeyState174)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState175 = Program.GetAsyncKeyState(1);
					if (asyncKeyState175)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState176 = Program.GetAsyncKeyState(1);
					if (asyncKeyState176)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState177 = Program.GetAsyncKeyState(1);
					if (asyncKeyState177)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState178 = Program.GetAsyncKeyState(1);
					if (asyncKeyState178)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState179 = Program.GetAsyncKeyState(1);
					if (asyncKeyState179)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState180 = Program.GetAsyncKeyState(1);
					if (asyncKeyState180)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState181 = Program.GetAsyncKeyState(1);
					if (asyncKeyState181)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState182 = Program.GetAsyncKeyState(1);
					if (asyncKeyState182)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState183 = Program.GetAsyncKeyState(1);
					if (asyncKeyState183)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState184 = Program.GetAsyncKeyState(1);
					if (asyncKeyState184)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState185 = Program.GetAsyncKeyState(1);
					if (asyncKeyState185)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState186 = Program.GetAsyncKeyState(1);
					if (asyncKeyState186)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState187 = Program.GetAsyncKeyState(1);
					if (asyncKeyState187)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState188 = Program.GetAsyncKeyState(1);
					if (asyncKeyState188)
					{
						Program.move(0, 1, 20, 1);
					}
					bool asyncKeyState189 = Program.GetAsyncKeyState(1);
					if (asyncKeyState189)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState190 = Program.GetAsyncKeyState(1);
					if (asyncKeyState190)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState191 = Program.GetAsyncKeyState(1);
					if (asyncKeyState191)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState192 = Program.GetAsyncKeyState(1);
					if (asyncKeyState192)
					{
						Program.move(0, 1, 20, 1);
					}
					bool asyncKeyState193 = Program.GetAsyncKeyState(1);
					if (asyncKeyState193)
					{
						Program.move(0, 1, 20, 1);
					}
					bool asyncKeyState194 = Program.GetAsyncKeyState(1);
					if (asyncKeyState194)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState195 = Program.GetAsyncKeyState(1);
					if (asyncKeyState195)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState196 = Program.GetAsyncKeyState(1);
					if (asyncKeyState196)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState197 = Program.GetAsyncKeyState(1);
					if (asyncKeyState197)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState198 = Program.GetAsyncKeyState(1);
					if (asyncKeyState198)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState199 = Program.GetAsyncKeyState(1);
					if (asyncKeyState199)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState200 = Program.GetAsyncKeyState(1);
					if (asyncKeyState200)
					{
						Program.move(1, 0, 20, 1);
					}
					bool asyncKeyState201 = Program.GetAsyncKeyState(1);
					if (asyncKeyState201)
					{
						Program.move(1, 0, 20, 1);
					}
					bool asyncKeyState202 = Program.GetAsyncKeyState(1);
					if (asyncKeyState202)
					{
						Program.move(1, 0, 20, 1);
					}
					bool asyncKeyState203 = Program.GetAsyncKeyState(1);
					if (asyncKeyState203)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState204 = Program.GetAsyncKeyState(1);
					if (asyncKeyState204)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState205 = Program.GetAsyncKeyState(1);
					if (asyncKeyState205)
					{
						Program.move(1, 0, 20, 1);
					}
					bool asyncKeyState206 = Program.GetAsyncKeyState(1);
					if (asyncKeyState206)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState207 = Program.GetAsyncKeyState(1);
					if (asyncKeyState207)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState208 = Program.GetAsyncKeyState(1);
					if (asyncKeyState208)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState209 = Program.GetAsyncKeyState(1);
					if (asyncKeyState209)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState210 = Program.GetAsyncKeyState(1);
					if (asyncKeyState210)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState211 = Program.GetAsyncKeyState(1);
					if (asyncKeyState211)
					{
						Program.move(1, 1, 300, 1);
					}
					bool asyncKeyState212 = Program.GetAsyncKeyState(1);
					if (asyncKeyState212)
					{
						Program.move(0, 8, 300, 1);
					}
				}
				bool flag3 = Program.mp5;
				if (flag3)
				{
					bool asyncKeyState213 = Program.GetAsyncKeyState(1);
					if (asyncKeyState213)
					{
						Program.move(0, 3, 24, 1);
					}
					bool asyncKeyState214 = Program.GetAsyncKeyState(1);
					if (asyncKeyState214)
					{
						Program.move(0, 3, 24, 1);
					}
					bool asyncKeyState215 = Program.GetAsyncKeyState(1);
					if (asyncKeyState215)
					{
						Program.move(0, 4, 23, 1);
					}
					bool asyncKeyState216 = Program.GetAsyncKeyState(1);
					if (asyncKeyState216)
					{
						Program.move(0, 4, 24, 1);
					}
					bool asyncKeyState217 = Program.GetAsyncKeyState(1);
					if (asyncKeyState217)
					{
						Program.move(0, 4, 24, 1);
					}
					bool asyncKeyState218 = Program.GetAsyncKeyState(1);
					if (asyncKeyState218)
					{
						Program.move(0, 5, 24, 1);
					}
					bool asyncKeyState219 = Program.GetAsyncKeyState(1);
					if (asyncKeyState219)
					{
						Program.move(0, 5, 23, 1);
					}
					bool asyncKeyState220 = Program.GetAsyncKeyState(1);
					if (asyncKeyState220)
					{
						Program.move(0, 4, 24, 1);
					}
					bool asyncKeyState221 = Program.GetAsyncKeyState(1);
					if (asyncKeyState221)
					{
						Program.move(0, 4, 24, 1);
					}
					bool asyncKeyState222 = Program.GetAsyncKeyState(1);
					if (asyncKeyState222)
					{
						Program.move(1, 4, 24, 1);
					}
					bool asyncKeyState223 = Program.GetAsyncKeyState(1);
					if (asyncKeyState223)
					{
						Program.move(1, 4, 23, 1);
					}
					bool asyncKeyState224 = Program.GetAsyncKeyState(1);
					if (asyncKeyState224)
					{
						Program.move(1, 5, 24, 1);
					}
					bool asyncKeyState225 = Program.GetAsyncKeyState(1);
					if (asyncKeyState225)
					{
						Program.move(3, 5, 24, 1);
					}
					bool asyncKeyState226 = Program.GetAsyncKeyState(1);
					if (asyncKeyState226)
					{
						Program.move(4, 5, 24, 1);
					}
					bool asyncKeyState227 = Program.GetAsyncKeyState(1);
					if (asyncKeyState227)
					{
						Program.move(4, 4, 23, 1);
					}
					bool asyncKeyState228 = Program.GetAsyncKeyState(1);
					if (asyncKeyState228)
					{
						Program.move(4, 4, 24, 1);
					}
					bool asyncKeyState229 = Program.GetAsyncKeyState(1);
					if (asyncKeyState229)
					{
						Program.move(3, 4, 24, 1);
					}
					bool asyncKeyState230 = Program.GetAsyncKeyState(1);
					if (asyncKeyState230)
					{
						Program.move(4, 4, 24, 1);
					}
					bool asyncKeyState231 = Program.GetAsyncKeyState(1);
					if (asyncKeyState231)
					{
						Program.move(4, 3, 23, 1);
					}
					bool asyncKeyState232 = Program.GetAsyncKeyState(1);
					if (asyncKeyState232)
					{
						Program.move(4, 3, 24, 1);
					}
					bool asyncKeyState233 = Program.GetAsyncKeyState(1);
					if (asyncKeyState233)
					{
						Program.move(4, 4, 24, 1);
					}
					bool asyncKeyState234 = Program.GetAsyncKeyState(1);
					if (asyncKeyState234)
					{
						Program.move(4, 3, 24, 1);
					}
					bool asyncKeyState235 = Program.GetAsyncKeyState(1);
					if (asyncKeyState235)
					{
						Program.move(4, 3, 23, 1);
					}
					bool asyncKeyState236 = Program.GetAsyncKeyState(1);
					if (asyncKeyState236)
					{
						Program.move(3, 3, 24, 1);
					}
					bool asyncKeyState237 = Program.GetAsyncKeyState(1);
					if (asyncKeyState237)
					{
						Program.move(3, 3, 24, 1);
					}
					bool asyncKeyState238 = Program.GetAsyncKeyState(1);
					if (asyncKeyState238)
					{
						Program.move(3, 3, 24, 1);
					}
					bool asyncKeyState239 = Program.GetAsyncKeyState(1);
					if (asyncKeyState239)
					{
						Program.move(2, 2, 23, 1);
					}
					bool asyncKeyState240 = Program.GetAsyncKeyState(1);
					if (asyncKeyState240)
					{
						Program.move(2, 2, 24, 1);
					}
					bool asyncKeyState241 = Program.GetAsyncKeyState(1);
					if (asyncKeyState241)
					{
						Program.move(-1, 2, 24, 1);
					}
					bool asyncKeyState242 = Program.GetAsyncKeyState(1);
					if (asyncKeyState242)
					{
						Program.move(-1, 2, 24, 1);
					}
					bool asyncKeyState243 = Program.GetAsyncKeyState(1);
					if (asyncKeyState243)
					{
						Program.move(-2, 1, 23, 1);
					}
					bool asyncKeyState244 = Program.GetAsyncKeyState(1);
					if (asyncKeyState244)
					{
						Program.move(-2, 1, 24, 1);
					}
					bool asyncKeyState245 = Program.GetAsyncKeyState(1);
					if (asyncKeyState245)
					{
						Program.move(-3, 2, 24, 1);
					}
					bool asyncKeyState246 = Program.GetAsyncKeyState(1);
					if (asyncKeyState246)
					{
						Program.move(-3, 1, 24, 1);
					}
					bool asyncKeyState247 = Program.GetAsyncKeyState(1);
					if (asyncKeyState247)
					{
						Program.move(-3, 1, 23, 1);
					}
					bool asyncKeyState248 = Program.GetAsyncKeyState(1);
					if (asyncKeyState248)
					{
						Program.move(-2, 1, 24, 1);
					}
					bool asyncKeyState249 = Program.GetAsyncKeyState(1);
					if (asyncKeyState249)
					{
						Program.move(-3, 1, 24, 1);
					}
					bool asyncKeyState250 = Program.GetAsyncKeyState(1);
					if (asyncKeyState250)
					{
						Program.move(-3, 1, 24, 1);
					}
					bool asyncKeyState251 = Program.GetAsyncKeyState(1);
					if (asyncKeyState251)
					{
						Program.move(-3, 2, 23, 1);
					}
					bool asyncKeyState252 = Program.GetAsyncKeyState(1);
					if (asyncKeyState252)
					{
						Program.move(-2, 2, 24, 1);
					}
					bool asyncKeyState253 = Program.GetAsyncKeyState(1);
					if (asyncKeyState253)
					{
						Program.move(-2, 2, 24, 1);
					}
					bool asyncKeyState254 = Program.GetAsyncKeyState(1);
					if (asyncKeyState254)
					{
						Program.move(-1, 2, 24, 1);
					}
					bool asyncKeyState255 = Program.GetAsyncKeyState(1);
					if (asyncKeyState255)
					{
						Program.move(-1, 1, 23, 1);
					}
					bool asyncKeyState256 = Program.GetAsyncKeyState(1);
					if (asyncKeyState256)
					{
						Program.move(-1, 1, 24, 1);
					}
					bool asyncKeyState257 = Program.GetAsyncKeyState(1);
					if (asyncKeyState257)
					{
						Program.move(0, 1, 24, 1);
					}
					bool asyncKeyState258 = Program.GetAsyncKeyState(1);
					if (asyncKeyState258)
					{
						Program.move(0, 1, 24, 1);
					}
					bool asyncKeyState259 = Program.GetAsyncKeyState(1);
					if (asyncKeyState259)
					{
						Program.move(0, 1, 23, 1);
					}
					bool asyncKeyState260 = Program.GetAsyncKeyState(1);
					if (asyncKeyState260)
					{
						Program.move(0, 1, 24, 1);
					}
					bool asyncKeyState261 = Program.GetAsyncKeyState(1);
					if (asyncKeyState261)
					{
						Program.move(0, 1, 24, 1);
					}
					bool asyncKeyState262 = Program.GetAsyncKeyState(1);
					if (asyncKeyState262)
					{
						Program.move(0, 1, 24, 1);
					}
					bool asyncKeyState263 = Program.GetAsyncKeyState(1);
					if (asyncKeyState263)
					{
						Program.move(0, 1, 23, 1);
					}
					bool asyncKeyState264 = Program.GetAsyncKeyState(1);
					if (asyncKeyState264)
					{
						Program.move(0, 1, 24, 1);
					}
					bool asyncKeyState265 = Program.GetAsyncKeyState(1);
					if (asyncKeyState265)
					{
						Program.move(2, 1, 24, 1);
					}
					bool asyncKeyState266 = Program.GetAsyncKeyState(1);
					if (asyncKeyState266)
					{
						Program.move(2, 1, 24, 1);
					}
					bool asyncKeyState267 = Program.GetAsyncKeyState(1);
					if (asyncKeyState267)
					{
						Program.move(2, 1, 23, 1);
					}
					bool asyncKeyState268 = Program.GetAsyncKeyState(1);
					if (asyncKeyState268)
					{
						Program.move(2, 1, 24, 1);
					}
					bool asyncKeyState269 = Program.GetAsyncKeyState(1);
					if (asyncKeyState269)
					{
						Program.move(2, 0, 24, 1);
					}
					bool asyncKeyState270 = Program.GetAsyncKeyState(1);
					if (asyncKeyState270)
					{
						Program.move(2, 1, 24, 1);
					}
					bool asyncKeyState271 = Program.GetAsyncKeyState(1);
					if (asyncKeyState271)
					{
						Program.move(3, 0, 23, 1);
					}
					bool asyncKeyState272 = Program.GetAsyncKeyState(1);
					if (asyncKeyState272)
					{
						Program.move(3, 1, 24, 1);
					}
					bool asyncKeyState273 = Program.GetAsyncKeyState(1);
					if (asyncKeyState273)
					{
						Program.move(3, 0, 24, 1);
					}
					bool asyncKeyState274 = Program.GetAsyncKeyState(1);
					if (asyncKeyState274)
					{
						Program.move(3, 1, 24, 1);
					}
					bool asyncKeyState275 = Program.GetAsyncKeyState(1);
					if (asyncKeyState275)
					{
						Program.move(2, 0, 23, 1);
					}
					bool asyncKeyState276 = Program.GetAsyncKeyState(1);
					if (asyncKeyState276)
					{
						Program.move(2, 1, 24, 1);
					}
					bool asyncKeyState277 = Program.GetAsyncKeyState(1);
					if (asyncKeyState277)
					{
						Program.move(2, 0, 24, 1);
					}
					bool asyncKeyState278 = Program.GetAsyncKeyState(1);
					if (asyncKeyState278)
					{
						Program.move(2, 0, 24, 1);
					}
					bool asyncKeyState279 = Program.GetAsyncKeyState(1);
					if (asyncKeyState279)
					{
						Program.move(2, 0, 23, 1);
					}
					bool asyncKeyState280 = Program.GetAsyncKeyState(1);
					if (asyncKeyState280)
					{
						Program.move(2, 0, 24, 1);
					}
					bool asyncKeyState281 = Program.GetAsyncKeyState(1);
					if (asyncKeyState281)
					{
						Program.move(0, 0, 24, 1);
					}
					bool asyncKeyState282 = Program.GetAsyncKeyState(1);
					if (asyncKeyState282)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState283 = Program.GetAsyncKeyState(1);
					if (asyncKeyState283)
					{
						Program.move(-1, 0, 23, 1);
					}
					bool asyncKeyState284 = Program.GetAsyncKeyState(1);
					if (asyncKeyState284)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState285 = Program.GetAsyncKeyState(1);
					if (asyncKeyState285)
					{
						Program.move(0, 0, 24, 1);
					}
					bool asyncKeyState286 = Program.GetAsyncKeyState(1);
					if (asyncKeyState286)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState287 = Program.GetAsyncKeyState(1);
					if (asyncKeyState287)
					{
						Program.move(-1, 0, 23, 1);
					}
					bool asyncKeyState288 = Program.GetAsyncKeyState(1);
					if (asyncKeyState288)
					{
						Program.move(0, 0, 24, 1);
					}
					bool asyncKeyState289 = Program.GetAsyncKeyState(1);
					if (asyncKeyState289)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState290 = Program.GetAsyncKeyState(1);
					if (asyncKeyState290)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState291 = Program.GetAsyncKeyState(1);
					if (asyncKeyState291)
					{
						Program.move(-1, 0, 23, 1);
					}
					bool asyncKeyState292 = Program.GetAsyncKeyState(1);
					if (asyncKeyState292)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState293 = Program.GetAsyncKeyState(1);
					if (asyncKeyState293)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState294 = Program.GetAsyncKeyState(1);
					if (asyncKeyState294)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState295 = Program.GetAsyncKeyState(1);
					if (asyncKeyState295)
					{
						Program.move(-2, 0, 23, 1);
					}
					bool asyncKeyState296 = Program.GetAsyncKeyState(1);
					if (asyncKeyState296)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState297 = Program.GetAsyncKeyState(1);
					if (asyncKeyState297)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState298 = Program.GetAsyncKeyState(1);
					if (asyncKeyState298)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState299 = Program.GetAsyncKeyState(1);
					if (asyncKeyState299)
					{
						Program.move(-2, 0, 23, 1);
					}
					bool asyncKeyState300 = Program.GetAsyncKeyState(1);
					if (asyncKeyState300)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState301 = Program.GetAsyncKeyState(1);
					if (asyncKeyState301)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState302 = Program.GetAsyncKeyState(1);
					if (asyncKeyState302)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState303 = Program.GetAsyncKeyState(1);
					if (asyncKeyState303)
					{
						Program.move(-2, 0, 23, 1);
					}
					bool asyncKeyState304 = Program.GetAsyncKeyState(1);
					if (asyncKeyState304)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState305 = Program.GetAsyncKeyState(1);
					if (asyncKeyState305)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState306 = Program.GetAsyncKeyState(1);
					if (asyncKeyState306)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState307 = Program.GetAsyncKeyState(1);
					if (asyncKeyState307)
					{
						Program.move(-2, 0, 23, 1);
					}
					bool asyncKeyState308 = Program.GetAsyncKeyState(1);
					if (asyncKeyState308)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState309 = Program.GetAsyncKeyState(1);
					if (asyncKeyState309)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState310 = Program.GetAsyncKeyState(1);
					if (asyncKeyState310)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState311 = Program.GetAsyncKeyState(1);
					if (asyncKeyState311)
					{
						Program.move(-1, 0, 23, 1);
					}
					bool asyncKeyState312 = Program.GetAsyncKeyState(1);
					if (asyncKeyState312)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState313 = Program.GetAsyncKeyState(1);
					if (asyncKeyState313)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState314 = Program.GetAsyncKeyState(1);
					if (asyncKeyState314)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState315 = Program.GetAsyncKeyState(1);
					if (asyncKeyState315)
					{
						Program.move(-1, 0, 23, 1);
					}
					bool asyncKeyState316 = Program.GetAsyncKeyState(1);
					if (asyncKeyState316)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState317 = Program.GetAsyncKeyState(1);
					if (asyncKeyState317)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState318 = Program.GetAsyncKeyState(1);
					if (asyncKeyState318)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState319 = Program.GetAsyncKeyState(1);
					if (asyncKeyState319)
					{
						Program.move(-1, 0, 23, 1);
					}
					bool asyncKeyState320 = Program.GetAsyncKeyState(1);
					if (asyncKeyState320)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState321 = Program.GetAsyncKeyState(1);
					if (asyncKeyState321)
					{
						Program.move(-2, 0, 24, 1);
					}
					bool asyncKeyState322 = Program.GetAsyncKeyState(1);
					if (asyncKeyState322)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState323 = Program.GetAsyncKeyState(1);
					if (asyncKeyState323)
					{
						Program.move(-1, 0, 23, 1);
					}
					bool asyncKeyState324 = Program.GetAsyncKeyState(1);
					if (asyncKeyState324)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState325 = Program.GetAsyncKeyState(1);
					if (asyncKeyState325)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState326 = Program.GetAsyncKeyState(1);
					if (asyncKeyState326)
					{
						Program.move(-1, 0, 24, 1);
					}
					bool asyncKeyState327 = Program.GetAsyncKeyState(1);
					if (asyncKeyState327)
					{
						Program.move(-1, 0, 23, 1);
					}
					bool asyncKeyState328 = Program.GetAsyncKeyState(1);
					if (asyncKeyState328)
					{
						Program.move(0, 0, 98, 1);
					}
					bool asyncKeyState329 = Program.GetAsyncKeyState(1);
					if (asyncKeyState329)
					{
						Program.move(0, 0, 98, 1);
					}
				}
				bool flag4 = Program.berdanka;
				if (flag4)
				{
					bool flag5 = Program.GetAsyncKeyState(6) && Program.berdankaIter < 4;
					if (flag5)
					{
						Program.move(0, 0, 30, 2);
						Program.move(0, 12, 0, 1);
						Program.move(0, 0, 0, 4);
						Program.move(0, 0, 54, 1);
						int num = Program.berdankaIter;
						Program.berdankaIter = num + 1;
					}
					bool flag6 = !Program.GetAsyncKeyState(6);
					if (flag6)
					{
						Program.berdankaIter = 0;
					}
				}
				bool flag7 = Program.smg;
				if (flag7)
				{
					bool asyncKeyState330 = Program.GetAsyncKeyState(1);
					if (asyncKeyState330)
					{
						Program.move(0, 0, 80, 1);
					}
					bool asyncKeyState331 = Program.GetAsyncKeyState(1);
					if (asyncKeyState331)
					{
						Program.move(-8, 17, 20, 1);
					}
					bool asyncKeyState332 = Program.GetAsyncKeyState(1);
					if (asyncKeyState332)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState333 = Program.GetAsyncKeyState(1);
					if (asyncKeyState333)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState334 = Program.GetAsyncKeyState(1);
					if (asyncKeyState334)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState335 = Program.GetAsyncKeyState(1);
					if (asyncKeyState335)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState336 = Program.GetAsyncKeyState(1);
					if (asyncKeyState336)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState337 = Program.GetAsyncKeyState(1);
					if (asyncKeyState337)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState338 = Program.GetAsyncKeyState(1);
					if (asyncKeyState338)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState339 = Program.GetAsyncKeyState(1);
					if (asyncKeyState339)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState340 = Program.GetAsyncKeyState(1);
					if (asyncKeyState340)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState341 = Program.GetAsyncKeyState(1);
					if (asyncKeyState341)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState342 = Program.GetAsyncKeyState(1);
					if (asyncKeyState342)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState343 = Program.GetAsyncKeyState(1);
					if (asyncKeyState343)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState344 = Program.GetAsyncKeyState(1);
					if (asyncKeyState344)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState345 = Program.GetAsyncKeyState(1);
					if (asyncKeyState345)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState346 = Program.GetAsyncKeyState(1);
					if (asyncKeyState346)
					{
						Program.move(0, 4, 20, 1);
					}
					bool asyncKeyState347 = Program.GetAsyncKeyState(1);
					if (asyncKeyState347)
					{
						Program.move(1, 2, 20, 1);
					}
					bool asyncKeyState348 = Program.GetAsyncKeyState(1);
					if (asyncKeyState348)
					{
						Program.move(1, 2, 20, 1);
					}
					bool asyncKeyState349 = Program.GetAsyncKeyState(1);
					if (asyncKeyState349)
					{
						Program.move(1, 2, 20, 1);
					}
					bool asyncKeyState350 = Program.GetAsyncKeyState(1);
					if (asyncKeyState350)
					{
						Program.move(1, 2, 20, 1);
					}
					bool asyncKeyState351 = Program.GetAsyncKeyState(1);
					if (asyncKeyState351)
					{
						Program.move(1, 2, 20, 1);
					}
					bool asyncKeyState352 = Program.GetAsyncKeyState(1);
					if (asyncKeyState352)
					{
						Program.move(1, 2, 20, 1);
					}
					bool asyncKeyState353 = Program.GetAsyncKeyState(1);
					if (asyncKeyState353)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState354 = Program.GetAsyncKeyState(1);
					if (asyncKeyState354)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState355 = Program.GetAsyncKeyState(1);
					if (asyncKeyState355)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState356 = Program.GetAsyncKeyState(1);
					if (asyncKeyState356)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState357 = Program.GetAsyncKeyState(1);
					if (asyncKeyState357)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState358 = Program.GetAsyncKeyState(1);
					if (asyncKeyState358)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState359 = Program.GetAsyncKeyState(1);
					if (asyncKeyState359)
					{
						Program.move(1, 3, 20, 1);
					}
					bool asyncKeyState360 = Program.GetAsyncKeyState(1);
					if (asyncKeyState360)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState361 = Program.GetAsyncKeyState(1);
					if (asyncKeyState361)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState362 = Program.GetAsyncKeyState(1);
					if (asyncKeyState362)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState363 = Program.GetAsyncKeyState(1);
					if (asyncKeyState363)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState364 = Program.GetAsyncKeyState(1);
					if (asyncKeyState364)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState365 = Program.GetAsyncKeyState(1);
					if (asyncKeyState365)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState366 = Program.GetAsyncKeyState(1);
					if (asyncKeyState366)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState367 = Program.GetAsyncKeyState(1);
					if (asyncKeyState367)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState368 = Program.GetAsyncKeyState(1);
					if (asyncKeyState368)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState369 = Program.GetAsyncKeyState(1);
					if (asyncKeyState369)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState370 = Program.GetAsyncKeyState(1);
					if (asyncKeyState370)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState371 = Program.GetAsyncKeyState(1);
					if (asyncKeyState371)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState372 = Program.GetAsyncKeyState(1);
					if (asyncKeyState372)
					{
						Program.move(-1, 1, 20, 1);
					}
					bool asyncKeyState373 = Program.GetAsyncKeyState(1);
					if (asyncKeyState373)
					{
						Program.move(-1, 1, 20, 1);
					}
					bool asyncKeyState374 = Program.GetAsyncKeyState(1);
					if (asyncKeyState374)
					{
						Program.move(-1, 1, 20, 1);
					}
					bool asyncKeyState375 = Program.GetAsyncKeyState(1);
					if (asyncKeyState375)
					{
						Program.move(-1, 1, 20, 1);
					}
					bool asyncKeyState376 = Program.GetAsyncKeyState(1);
					if (asyncKeyState376)
					{
						Program.move(-1, 1, 20, 1);
					}
					bool asyncKeyState377 = Program.GetAsyncKeyState(1);
					if (asyncKeyState377)
					{
						Program.move(-1, 1, 20, 1);
					}
					bool asyncKeyState378 = Program.GetAsyncKeyState(1);
					if (asyncKeyState378)
					{
						Program.move(0, 1, 20, 1);
					}
					bool asyncKeyState379 = Program.GetAsyncKeyState(1);
					if (asyncKeyState379)
					{
						Program.move(0, 1, 20, 1);
					}
					bool asyncKeyState380 = Program.GetAsyncKeyState(1);
					if (asyncKeyState380)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState381 = Program.GetAsyncKeyState(1);
					if (asyncKeyState381)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState382 = Program.GetAsyncKeyState(1);
					if (asyncKeyState382)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState383 = Program.GetAsyncKeyState(1);
					if (asyncKeyState383)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState384 = Program.GetAsyncKeyState(1);
					if (asyncKeyState384)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState385 = Program.GetAsyncKeyState(1);
					if (asyncKeyState385)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState386 = Program.GetAsyncKeyState(1);
					if (asyncKeyState386)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState387 = Program.GetAsyncKeyState(1);
					if (asyncKeyState387)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState388 = Program.GetAsyncKeyState(1);
					if (asyncKeyState388)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState389 = Program.GetAsyncKeyState(1);
					if (asyncKeyState389)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState390 = Program.GetAsyncKeyState(1);
					if (asyncKeyState390)
					{
						Program.move(-1, 2, 20, 1);
					}
					bool asyncKeyState391 = Program.GetAsyncKeyState(1);
					if (asyncKeyState391)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState392 = Program.GetAsyncKeyState(1);
					if (asyncKeyState392)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState393 = Program.GetAsyncKeyState(1);
					if (asyncKeyState393)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState394 = Program.GetAsyncKeyState(1);
					if (asyncKeyState394)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState395 = Program.GetAsyncKeyState(1);
					if (asyncKeyState395)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState396 = Program.GetAsyncKeyState(1);
					if (asyncKeyState396)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState397 = Program.GetAsyncKeyState(1);
					if (asyncKeyState397)
					{
						Program.move(0, 1, 20, 1);
					}
					bool asyncKeyState398 = Program.GetAsyncKeyState(1);
					if (asyncKeyState398)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState399 = Program.GetAsyncKeyState(1);
					if (asyncKeyState399)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState400 = Program.GetAsyncKeyState(1);
					if (asyncKeyState400)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState401 = Program.GetAsyncKeyState(1);
					if (asyncKeyState401)
					{
						Program.move(0, 1, 20, 1);
					}
					bool asyncKeyState402 = Program.GetAsyncKeyState(1);
					if (asyncKeyState402)
					{
						Program.move(0, 1, 20, 1);
					}
					bool asyncKeyState403 = Program.GetAsyncKeyState(1);
					if (asyncKeyState403)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState404 = Program.GetAsyncKeyState(1);
					if (asyncKeyState404)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState405 = Program.GetAsyncKeyState(1);
					if (asyncKeyState405)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState406 = Program.GetAsyncKeyState(1);
					if (asyncKeyState406)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState407 = Program.GetAsyncKeyState(1);
					if (asyncKeyState407)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState408 = Program.GetAsyncKeyState(1);
					if (asyncKeyState408)
					{
						Program.move(0, 2, 20, 1);
					}
					bool asyncKeyState409 = Program.GetAsyncKeyState(1);
					if (asyncKeyState409)
					{
						Program.move(1, 0, 20, 1);
					}
					bool asyncKeyState410 = Program.GetAsyncKeyState(1);
					if (asyncKeyState410)
					{
						Program.move(1, 0, 20, 1);
					}
					bool asyncKeyState411 = Program.GetAsyncKeyState(1);
					if (asyncKeyState411)
					{
						Program.move(1, 0, 20, 1);
					}
					bool asyncKeyState412 = Program.GetAsyncKeyState(1);
					if (asyncKeyState412)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState413 = Program.GetAsyncKeyState(1);
					if (asyncKeyState413)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState414 = Program.GetAsyncKeyState(1);
					if (asyncKeyState414)
					{
						Program.move(1, 0, 20, 1);
					}
					bool asyncKeyState415 = Program.GetAsyncKeyState(1);
					if (asyncKeyState415)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState416 = Program.GetAsyncKeyState(1);
					if (asyncKeyState416)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState417 = Program.GetAsyncKeyState(1);
					if (asyncKeyState417)
					{
						Program.move(0, 0, 20, 1);
					}
					bool asyncKeyState418 = Program.GetAsyncKeyState(1);
					if (asyncKeyState418)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState419 = Program.GetAsyncKeyState(1);
					if (asyncKeyState419)
					{
						Program.move(1, 1, 20, 1);
					}
					bool asyncKeyState420 = Program.GetAsyncKeyState(1);
					if (asyncKeyState420)
					{
						Program.move(1, 1, 300, 1);
					}
					bool asyncKeyState421 = Program.GetAsyncKeyState(1);
					if (asyncKeyState421)
					{
						Program.move(0, 8, 300, 1);
					}
				}
				bool flag8 = Program.python;
				if (flag8)
				{
					bool flag9 = Program.GetAsyncKeyState(6) && Program.pythonIter < 4;
					if (flag9)
					{
						Program.move(0, 0, 1, 2);
						Program.move(0, 0, 0, 4);
						Program.move(0, 22, 85, 1);
						Program.move(0, 0, 1, 2);
						Program.move(0, 0, 0, 4);
						Program.move(0, 22, 85, 1);
						int num = Program.pythonIter;
						Program.pythonIter = num + 1;
					}
					bool flag10 = !Program.GetAsyncKeyState(6);
					if (flag10)
					{
						Program.pythonIter = 0;
					}
				}
				Thread.Sleep(1);
			}
		}

		// Token: 0x04000001 RID: 1
		public static bool ak;

		// Token: 0x04000002 RID: 2
		public static bool thompson;

		// Token: 0x04000003 RID: 3
		public static bool mp5;

		// Token: 0x04000004 RID: 4
		public static bool berdanka;

		// Token: 0x04000005 RID: 5
		public static bool smg;

		// Token: 0x04000006 RID: 6
		public static bool python = false;

		// Token: 0x04000007 RID: 7
		public static int pythonIter = 0;

		// Token: 0x04000008 RID: 8
		public static int berdankaIter = 0;
	}
}
