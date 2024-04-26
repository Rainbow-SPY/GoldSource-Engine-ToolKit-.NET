// See https://github.com/Rainbow-SPY/GoldSource-Engine-ToolKit-.NET for more information
// Develper Says:
// This is a C# (csharp) console application written by .NET 8.0.
// 
// This project need .NET Framework 8.0
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System;
using System.Diagnostics;
using System.Reflection.Emit;
using Windows.ApplicationModel.Background;
using Microsoft.Win32;
using System.Xml.Linq;
using System.Configuration;
using System.IO;
string Command_Game;
string CstrikeCommand_1;
string CstrikeCommand_2;
string CstrikeCommand_3;
string CstrikeCommand_4;

string HostArchitecture;
string HostBuild;
string HostReleaseVersion;
string HostDisplayVersion;
string HostEdition;
string HostInstallationType;
string HostOSName;
string HostServicePackBuild;
string HostVersion;
string HostUILanguage;
string HostLanguage;
string HostPartiallyLocalized;
string HostLanguageFallback;

string HlCommand_1;
string HlCommand_2;
string HlCommand_3;
string HlCommand_4;


string Downloadcdn1 = "https://raw.kkgithub.com/Rainbow-SPY/GoldSource-Engine-ToolKit/master";
string Downloadcdn2 = "https://mirror.ghproxy.com";
string Downloadcdn3 = "https://ghproxy.netm";
string Downloadcdn4 = "https://fastraw.ixnic.net/Rainbow-SPY/GoldSource-Engine-ToolKit/master";
string Downloadcdn5 = "https://github.moeyy.xyz";
string Downloadcdn6 = "https://raw.cachefly.998111.xyz/Rainbow-SPY/GoldSource-Engine-ToolKit/master";
//赋值
string DownloadLink1 = "Rainbow-SPY/GoldSource-Engine-ToolKit/resource/resource-1.1.0-Offical.7z";
string DownloadLink2 = "Rainbow-SPY/GoldSource-Engine-ToolKit/resource/cstrike_schinese/titles.txt";
string DownloadLink3 = "Rainbow-SPY/GoldSource-Engine-ToolKit/resource/cstrike_english.txt";
string DownloadLink4 = "Rainbow-SPY/GoldSource-Engine-ToolKit/resource/gameui_english.txt";
string DownloadLink5 = "Rainbow-SPY/GoldSource-Engine-ToolKit/resource/serverbrowser_english.txt";
string DownloadLink6 = "Rainbow-SPY/GoldSource-Engine-ToolKit/resource/valve_english.txt";
//赋值
string ver = "v2.1";
string ShortTag = "GoldSource";
string ShortName = "GoldSource Engine";
string cstrike_ver = "Counter Strike 1.6 Steam ver.";
string ToolKit_Appdata = "%LOCALAPPDATA%/GoldSource-Engine-ToolKit/bin";
string ToolKit_App;//初始化赋值

if (Directory.Exists("D:/"))//检测是否有D盘
{
    ToolKit_App = "D:/Gold Source Engine ToolKit x64 zh-CN";//设置工作路径
    if (Directory.Exists(ToolKit_App))//检测工作路径是否有
    {
        Console.WriteLine("已找到主程序文件夹: " + ToolKit_App);//在控制台上打印,类似于echo
    }
    else//反之
    {
        Directory.CreateDirectory(ToolKit_App);//创建工作目录
        Console.WriteLine("已找到主程序文件夹: " + ToolKit_App);//打印文字

    }
}
else//反之
{
    ToolKit_App = "C:/Gold Source Engine ToolKit x64 zh-CN";//不需要string和var,直接赋值
    if (Directory.Exists(ToolKit_App))
    {
        Console.WriteLine("已找到主程序文件夹: " + ToolKit_App);
    }
    else
    {
        Directory.CreateDirectory(ToolKit_App);
        Console.WriteLine("已找到主程序文件夹: " + ToolKit_App);

    }

}

string FormTitle = "GoldSource Engine ToolKit 版本: %ver%";
string _line = "-------------------------------------";
Console.SetWindowSize(80, 25);
//Console.SetBufferSize(80, 25);
Console.Title = "Welcome! - GoldSource Engine ToolKit .NET ver 1.0";//设置窗口标题

if (Directory.Exists(ToolKit_App + "/Download"))//检测下载目录
{
    string txtPattern = "*.*";
    string[] txtFiles = Directory.GetFiles(ToolKit_App + "/Download", txtPattern);
    foreach (string currentFile in txtFiles)
    {
        File.Delete(currentFile);
    }

}
else
{
    Directory.CreateDirectory(ToolKit_App + "/Download");//反之创建目录
}

if (Directory.Exists(ToolKit_Appdata))//检测数据文件夹
{
    Console.WriteLine("存在");
}
else
{
    Console.WriteLine("No");
    Directory.CreateDirectory(ToolKit_Appdata);//创建文件夹
}

if (Directory.Exists(ToolKit_Appdata + "/Backup"))//检测备份文件夹
{
    Console.WriteLine("存在");
}
else
{
    Console.WriteLine("No");
    Directory.CreateDirectory(ToolKit_Appdata + "/Backup");
}

if (Directory.Exists("C:/Windows/SysWOW64"))
{
    HostArchitecture = "x64";
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Red");
}
else
{
    HostArchitecture = "x86";
}
Console.ResetColor();
Console.Clear();
Console.WriteLine("===============================================================================");
Console.WriteLine("######################## GE 工具箱  - 最终用户许可协议 #########################");
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" Copyright(C) Rainbow SPY Technology(2019 - 2024).All rights reserved.");
Console.ResetColor();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" GE 工具箱仅限用于金源引擎开发的游戏");
Console.WriteLine();
Console.WriteLine();
Console.Write(" 此 GE 工具箱按");
Console.ForegroundColor= ConsoleColor.Red;
Console.Write("\"开发者提供的原样\"");
Console.ResetColor();
Console.WriteLine(" 提供，并且不作任何明示或暗示性的保证.在任何");
Console.WriteLine(" 情况之下，作者均不会对因为使用此脚本配置工具而导致可能的任何破坏承担责任.");
Console.WriteLine(" 此软件不用于任何商业行为，出现任何法律问题将有使用者承担。");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" GE 工具箱将会使用各类第三方工具来完成其中的一部分任务行为。");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" GE 工具箱、金源引擎、GoldSource Engine 均为其各自公司或作者的注册商标。");
Console. ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" (C) Microsoft Corporation. All rights reserved.");
Console.WriteLine(" 7-Zip Copyright (C) 1999-2018 Igor Pavlov.");
Console.WriteLine(" Copyright (C) 2021 Valve Corporation");
Console.ResetColor();
Console.WriteLine("===============================================================================");
Console.WriteLine("########################[ 按‘A’同意 / 按‘R’拒绝 ]#########################");
KeyJump:
ConsoleKeyInfo keyInfo = Console.ReadKey(intercept:true);
if (keyInfo.KeyChar == 'r' )//|| keyInfo.KeyChar == 'a')
{
    Environment.Exit(0);
}
else
{
    if (keyInfo.KeyChar == 'a')
    {
        goto Instruction;
    }
    goto KeyJump;
}
Instruction:
Console.Title = "Instruction - GoldSource Engine ToolKit .NET ver 1.0 ";
Console.Clear();
Console.ResetColor();
Console.WriteLine("===============================================================================");
Console.WriteLine("############################ GE 工具箱  - 使用说明 #############################");
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine(" 使用说明");
Console.WriteLine();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(" 请勿使用管理员权限运行本工具箱!");
Console.ResetColor();
Console.Write(" 避免工具箱数据遭到篡改.");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" 工具箱会向注册表添加必要的数据, 请注意杀毒软件是否开启了免打扰模式!");
Console.WriteLine();
Console.WriteLine();
Console.ForegroundColor= ConsoleColor.Red;
Console.Write(" 工具箱无任何敏感操作 ");
Console.ResetColor();
Console.WriteLine(" 请注意数据是否遭到篡改");
Console.WriteLine();
//onsole.WriteLine();
Console.WriteLine();
Console.WriteLine(" 工具箱会读取您的Steam相关数据, 请确保您的Steam正在运行");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" 工具箱会读取Counter-Strike的相关数据, 在必要时需要您运行Counter-Strike");
Console.WriteLine();
Console.WriteLine("===============================================================================");
Console.WriteLine("############################[ 10 秒后关闭界面... ]#############################");
//Thread.Sleep(10000);//Wait 10 second
Console.ReadKey();
ComputerInfo:
Console.Clear();
if (Directory.Exists("C:/Windows/SysWOW64"))
{
    HostArchitecture = "x64";
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Red");
}
else
{
    HostArchitecture = "x86";
}
GetHostsInfo:
Console.ResetColor();
Console.Title = "//Get information... -GoldSource Engine ToolKit ver 2.1.0";
Console.Clear();
Console.WriteLine("===============================================================================");
Console.WriteLine("                          GE 工具箱 - 启动");
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine(" 正在读取主机操作系统信息……");
Console.WriteLine();
Console.WriteLine(" Windows %HostOSVersion% %HostEdition% %HostInstallationType% %HostDisplayVersion% - v%HostVersion%.%HostBuild%.%HostServicePackBuild% %HostArchitecture% %HostLanguage%");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" 正在读取Steam数据...");
GetSteamInfo:
Console.WriteLine();
Console.WriteLine();
Process[] SteamProcess = Process.GetProcessesByName("Steam");
if (SteamProcess.Length == 0)
{
    Console.WriteLine("Not running");
}
else
{
    Console.WriteLine("Running");
}
Console.ReadKey();