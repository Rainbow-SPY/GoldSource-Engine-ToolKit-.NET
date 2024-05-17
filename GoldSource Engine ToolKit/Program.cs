//   See https://github.com/Rainbow-SPY/GoldSource-Engine-ToolKit-.NET for more Data
//   Develper Says:
//
//   This is a C# (csharp) console application written by .NET 8.0.
//   
//   This project need .NET 8.0.4 Runtime SDK to run.
//   
//   Version : 1.0.0 For .NET 8.0
//  
//   Publisher : Rainbow-SPY , All rights reserved.
using Microsoft.Win32;
using System.Diagnostics;
using Tool.Extra;

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


string Downloadcdn1 = "https://raw.kkgithub.com";
string Downloadcdn2 = "https://mirror.ghproxy.com";
string Downloadcdn3 = "https://ghproxy.net";
string Downloadcdn4 = "https://fastraw.ixnic.net";
string Downloadcdn5 = "https://github.moeyy.xyz/https://raw.githubusercontent.com";
string Downloadcdn6 = "https://raw.cachefly.998111.xyz";
//赋值
string DownloadLink1 = "Rainbow-SPY/GoldSource-Engine-ToolKit/resource/resource-1.1.0-Offical.7z";
string DownloadLink2 = "Rainbow-SPY/GoldSource-Engine-ToolKit/resource/cstrike_schinese/titles.txt";
string DownloadLink3 = "Rainbow-SPY/GoldSource-Engine-ToolKit/resource/cstrike_english.txt";
string DownloadLink4 = "Rainbow-SPY/GoldSource-Engine-ToolKit/resource/gameui_english.txt";
string DownloadLink5 = "Rainbow-SPY/GoldSource-Engine-ToolKit/resource/serverbrowser_english.txt";
string DownloadLink6 = "Rainbow-SPY/GoldSource-Engine-ToolKit/resource/valve_english.txt";
//赋值
string ver = "v1.0";
var verShort = "1.0";
string ShortTag = "GoldSource";
string ShortName = "GoldSource Engine";
string cstrike_ver = "Counter Strike 1.6 Steam ver.";
string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
string ToolKit_Appdata = ApplicationData + "/GoldSource-Engine-ToolKit/bin";
string ToolKit_App;//初始化赋值
string ToolKit_Data;
string ToolKit_Download;
string ToolKit_resource;
var ApplicationName = Process.GetCurrentProcess().ProcessName;
string ToolKit_Application = Directory.GetCurrentDirectory() + "\\" + ApplicationName + ".exe";
Console.Title = "Initialization... - GoldSource Engine ToolKit .NET ver 1.0";//设置窗口标题
ToolKit_App = Directory.GetCurrentDirectory();//直接获取运行目录

ToolKit_App = ToolKit_App.Replace("\\", "/");//example: C:/Folder/
ToolKit_Application = ToolKit_Application.Replace("\\", "/"); // example: C:/Folder/Application.exe

    ToolKit_Download = ToolKit_App + "/Download";//下载目录
    ToolKit_resource = ToolKit_App + "/resource";//引用的资源目录
    ToolKit_Data = ToolKit_App + "/data";//数据目录
//ToolKit.modules
var aria2c = ToolKit_App + "/modules/aria2/aria2c.exe";
var ExtractZip = ToolKit_App + "/modules/7-zip/7za.exe";
var NSudoLC= ToolKit_App + "/modules/NSudo/NSudoLC.exe";
if (File.Exists(ToolKit_App + "/ToolKit.Core.Launcher.exe"))
    {
    if (args.Length > 0 && args[0] == "-Launcher")//args[0] == "{anything}"
        {
        // Command
        }
        else
        {
        Console.WriteLine("未使用启动器启动工具箱,请重新启动!");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("按任意键退出...");
        Console.ReadKey();
        Environment.Exit(0);
        }
    }
        else
        {
    Console.WriteLine("应用程序安装不完整,请检查文件完整性.");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("按任意键退出...");
    Console.ReadKey();
    Environment.Exit(0);
        }
    if (!Directory.Exists(ToolKit_Data))
    {

    }
    else
    {
        Directory.CreateDirectory(ToolKit_Data);
    }
Console.SetWindowSize(80, 25);
Console.SetBufferSize(80,25);
Console.Title = "Welcome! - GoldSource Engine ToolKit .NET ver 1.0";//设置窗口标题

if (Directory.Exists(ToolKit_Download))//检测下载目录
{
    string txtPattern = "*.*";
    string[] txtFiles = Directory.GetFiles(ToolKit_Download, txtPattern);
    foreach (string currentFile in txtFiles)
    {
        File.Delete(currentFile);
    }
}
else
{
    Directory.CreateDirectory(ToolKit_Download);//反之创建目录
}

if (Directory.Exists(ToolKit_Appdata))//检测数据文件夹
{

}
else
{
    Directory.CreateDirectory(ToolKit_Appdata);//创建文件夹
}

if (!Directory.Exists(ToolKit_resource))
{

}
else
{
    Directory.CreateDirectory(ToolKit_resource);
}

if (Directory.Exists(ToolKit_Appdata + "/Backup"))//检测备份文件夹
{

}
else
{
    Directory.CreateDirectory(ToolKit_Appdata + "/Backup");
}

if (Directory.Exists("C:/Windows/SysWOW64"))
{
    HostArchitecture = "x64";
}
else
{
    HostArchitecture = "x86";
}
Console.ResetColor();
Console.Clear();
Console.WriteLine("===============================================================================");
Console.WriteLine("                          GE 工具箱  - 最终用户许可协议");
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
Console.ForegroundColor = ConsoleColor.Red;
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
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" (C) Microsoft Corporation. All rights reserved.");
Console.WriteLine(" 7-Zip Copyright (C) 1999-2018 Igor Pavlov.");
Console.WriteLine(" Copyright (C) 2021 Valve Corporation");
Console.ResetColor();
Console.WriteLine("===============================================================================");
Console.WriteLine("########################[ 按‘A’同意 / 按‘R’退出 ]#########################");
KeyJump:
ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
if (keyInfo.KeyChar == 'r')
{
    Environment.Exit(0);
}
else
{
    if (keyInfo.KeyChar == 'a')
    {
        goto Update;
    }
    goto KeyJump;
}
Update:
Console.Clear();
Console.Title = "Updating...";
Console.WriteLine("===============================================================================");
Console.WriteLine("                                GE 工具箱  - 更新 ");
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine("正在检查更新...");
Console.WriteLine();
string T_Download = "\"" + ToolKit_Download + "\"";
Process check = Process.Start(aria2c + " ","-x 16 -d " + T_Download + " " + "-q" + " " + "https://github.moeyy.xyz/https://raw.githubusercontent.com/Rainbow-SPY/GoldSource-Engine-ToolKit/resource/Version.ini");
check.WaitForExit();
Process info = Process.Start(aria2c + " ", "-x 16 -d " + T_Download + " " + "-q" + " " + "https://github.moeyy.xyz/https://raw.githubusercontent.com/Rainbow-SPY/GoldSource-Engine-ToolKit-.NET/resource/info.ini");
info.WaitForExit();
static void DelectLog(string srcPath)
{
    try
    {
        DirectoryInfo dir = new(srcPath);
        FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
        foreach (FileSystemInfo i in fileinfo)
        {
            if (i.Extension == ".js")
            {
                File.Delete(i.FullName);      //删除指定文件
            }
        }
    }
    catch (Exception e)
    {
        throw;
    }
}
var verAll = File.ReadAllText(ToolKit_App+"/Download/Version.ini");
//if (File.Exists(ToolKit_resource + "/ToolKit.Json.Download.list.json"))
//{

//}
string vernow = "0.1";//目前的版本
string FileToRead = ToolKit_App + "/Download/info.ini";
// Creating enumerable object  
IEnumerable<string> lined = File.ReadLines(FileToRead);
Console.WriteLine(string.Join(Environment.NewLine, lined));
if (verAll.Contains(vernow))
{
    Console.WriteLine("您当前已是最新版本");
    Console.WriteLine("按任意键继续...");
    Console.ReadKey();
    goto Instruction;
}
else
{
    Console.WriteLine("新版本 v" + verAll + "已发布, 是否更新?");
    Console.WriteLine("########################[ 按‘A’同意 / 按‘R’拒绝 ]#########################");
KeyJump2:
    ConsoleKeyInfo keyInfo1 = Console.ReadKey(intercept: true);
    if (keyInfo1.KeyChar == 'r')
    {
        goto Instruction;
    }
    else
    {
        if (keyInfo1.KeyChar == 'a')
        {
            Console.Clear();
            Console.Title = "Updating...";
            Console.WriteLine("===============================================================================");
            Console.WriteLine("                                GE 工具箱  - 更新 ");
            Console.WriteLine("===============================================================================");
            Console.WriteLine();
            Console.WriteLine("正在更新脚本...");
            ToolKit_Download = "\"" + ToolKit_Download + "\"";
            File.Delete(ToolKit_Data + "/ToolKit.Data.github.cdn-download.ini");
            File.Delete(ToolKit_Data + "/ToolKit.Data.github.cdn-download.cdn.ini");
            DelectLog(ToolKit_App + "/scripts");
            Process p1 = Process.Start(aria2c + " ", "-x 16 -d " + "\"" + ToolKit_App + "/scripts" + "\"" + " " + "-q https://update.greasyfork.org/scripts/412245/Github%20%E5%A2%9E%E5%BC%BA%20-%20%E9%AB%98%E9%80%9F%E4%B8%8B%E8%BD%BD.user.js");
            p1.WaitForExit();
            Console.WriteLine("脚本更新完成.");
            Console.WriteLine();
            string folderPath1 = ToolKit_App + "/scripts";
            string[] jsFiles1 = Directory.GetFiles(folderPath1, "*.js");
            if (jsFiles1.Length > 0)
            {
                string script3 = jsFiles1[0];
                script3 = script3.Replace("\\", "/");
                string input = File.ReadAllText(script3);
                string[] urls = ToolKit.ExtractUrl(input);
                using StreamWriter writer = new(ToolKit_Data + "/ToolKit.Data.github.cdn-download.cdn.ini");
                // 遍历数据集合，并写入文件
                foreach (string line in urls)
                {
                    writer.WriteLine(line);
                }
            }
            //int lines = readFileLines(ToolKit_Data + "/ToolKit.Data.github.cdn-download.cdn.ini");
            if (File.Exists(ToolKit_Data + "/ToolKit.Data.github.cdn-download.lines.ini"))
            {

            }
            else
            {
                File.Create(ToolKit_Data + "/ToolKit.Data.github.cdn-download.lines.ini");
            }
            string sourceFilePath = ToolKit_Data + "/ToolKit.Data.github.cdn-download.cdn.ini";
            string targetFilePath = ToolKit_Data + "/ToolKit.Data.github.cdn-download.lines.ini";
            int lineCount = File.ReadLines(sourceFilePath).Count();
            using (StreamWriter writer = new(targetFilePath))
            {
                writer.WriteLine("$ScriptLines=" + lineCount);
            }
            Console.WriteLine("正在下载资源包...(1/6)");
            Process p2 = Process.Start(aria2c + " ", "-x 16 -d " + ToolKit_Download + " " + "-q" + " " + Downloadcdn4 + "/" + DownloadLink1);
            p2.WaitForExit();
            Console.WriteLine("正在下载资源包...(2/6)");
            Process p3 = Process.Start(aria2c + " ", "-x 16 -d " + ToolKit_Download + " " + "-q" + " " + Downloadcdn4 + "/" + DownloadLink2);
            p3.WaitForExit();
            Console.WriteLine("正在下载资源包...(3/6)");
            Process p4 = Process.Start(aria2c + " ", "-x 16 -d " + ToolKit_Download + " " + "-q" + " " + Downloadcdn4 + "/" + DownloadLink3);
            p4.WaitForExit();
            Console.WriteLine("正在下载资源包...(4/6)");
            Process p5 = Process.Start(aria2c + " ", "-x 16 -d " + ToolKit_Download + " " + "-q" + " " + Downloadcdn4 + "/" + DownloadLink4);
            p5.WaitForExit();
            Console.WriteLine("正在下载资源包...(5/6)");
            Process p6 = Process.Start(aria2c + " ", "-x 16 -d " + ToolKit_Download + " " + "-q" + " " + Downloadcdn4 + "/" + DownloadLink5);
            p6.WaitForExit();
            Console.WriteLine("正在下载资源包...(6/6)");
            Process p7 = Process.Start(aria2c + " ", "-x 16 -d " + ToolKit_Download + " " + "-q" + " " + Downloadcdn6 + "/" + DownloadLink6);
            p7.WaitForExit();
            if (File.Exists(ToolKit_App + "/Download/resource-1.1.0-Offical.7z"))
            {
                Console.WriteLine("更新完成");
                Console.ReadKey();
                ToolKit.WriteIniFile(ToolKit_Data + "/ToolKit.data.update.ini","ResUpdate","True");
                Process[] process = Process.GetProcessesByName("aria2");
                foreach (Process p in process)
                {
                    p.Kill();
                }
                goto Instruction;
            }
            else
            {
                Process[] process = Process.GetProcessesByName("aria2");
                foreach (Process p in process)
                {
                    p.Kill();
                }
                Console.WriteLine("更新失败");
                Console.ReadKey();
                goto Instruction;
            }

        }
        goto KeyJump2;
    }

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
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(" 工具箱无任何敏感操作 ");
Console.ResetColor();
Console.WriteLine(" 请注意数据是否遭到篡改");
Console.WriteLine();
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
HostArchitecture = Environment.Is64BitOperatingSystem ? "x64" : "x86";

HostBuild = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", "").ToString();

HostReleaseVersion = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", "").ToString();
if (HostReleaseVersion.CompareTo("2004") < 0)
{
    string[] tokens = HostReleaseVersion.Split('.');
    HostReleaseVersion = tokens[0];
}

HostDisplayVersion = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "DisplayVersion", "").ToString();

HostEdition = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString();

HostInstallationType = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "InstallationType", "").ToString();
if (HostInstallationType == "Client")
{
    HostInstallationType = "客户端";
}

HostVersion = Environment.OSVersion.Version.ToString();
string HostOSVersion = HostVersion;
if (HostVersion == "6.1")
{
    HostOSVersion = "7 SP1";
}
else if (HostVersion == "6.3")
{
    HostOSVersion = "8.1";
}
else if (HostVersion == "10.0" && HostBuild.CompareTo("21996") >= 0)
{
    HostOSVersion = "11";
}
Console.Title = "Get Data... -GoldSource Engine ToolKit ver 2.1.0";
Console.Clear();
Console.ResetColor();
Console.WriteLine("===============================================================================");
Console.WriteLine("                          GE 工具箱 - 启动");
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine(" 正在读取主机操作系统信息……");
Console.WriteLine();
Console.Write(" " + HostEdition + " " + HostOSVersion + " " + HostInstallationType + " " + HostDisplayVersion + " " + HostArchitecture + " ");
Console.Write(Thread.CurrentThread.CurrentCulture.Name);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
GetSteamInfo:
Console.WriteLine(" 正在读取Steam数据...");
Console.WriteLine();
Console.WriteLine();
//Process[] SteamProcess = Process.GetProcessesByName("Steam");
//if (SteamProcess.Length == 0)
//{
//    string Task_Steam = "False";
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Steam未运行");
//    Thread.Sleep(1000);
//    goto GetSteamInfo;
//}
RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Valve\Steam");
string SteamApp;
string SteamUserData;
if (key != null)
{
    // 读取值
    var SteamPath = key.GetValue("SteamPath") as string;

    if (!string.IsNullOrEmpty(SteamPath))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("您的Steam路径:\t\t" + SteamPath);
        Console.WriteLine("您的SteamApp路径:\t\t" + SteamPath + "/steam.exe");
        SteamApp = SteamPath + "/steam.exe";
        ToolKit.WriteIniFile(ToolKit_App + "/data/ToolKit.Data.Steam.Path.ini", "$SteamPath", SteamPath);
        ToolKit.WriteIniFile(ToolKit_App + "/data/ToolKit.Data.Steam.App.ini", "$SteamApp", SteamApp);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("您的Steam用户文件夹:	" + SteamPath + "/userdata");
        Console.ResetColor();
        SteamUserData = SteamPath + "/userdata";
        ToolKit.WriteIniFile(ToolKit_App + "/data/ToolKit.Data.Steam.UserData.ini", "$SteamUserData", SteamUserData);

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        //Process p = Process.Start(ToolKit_App + "/System.Winplayer.exe");
        //p.StartInfo.Arguments = "";
        Console.WriteLine("未找到Steam注册表项.请检查您是否安装了Steam");
        Console.WriteLine("按任意键退出...");
        Console.ReadKey();
        Environment.Exit(0);
    }
    key.Close();
}

GetHalfLifeInto:
Console.WriteLine();
Console.WriteLine("正在尝试寻找Half-Life安装信息......");
Console.WriteLine();


if (File.Exists(ToolKit_Data + "/ToolKit.Data.Half-Life-Path.ini"))
{
    string HalfLifePath = File.ReadAllText(ToolKit_Data + "/ToolKit.Data.Half-Life.Path.ini");
    int equalSignIndex2 = HalfLifePath.IndexOf("＝");
    if (equalSignIndex2 != -1 && equalSignIndex2 < HalfLifePath.Length - 1)
    {
        string data = HalfLifePath[(equalSignIndex2 + 1)..];
    }
    Console.Write("已找到游戏路径:    " + HalfLifePath);
    Console.WriteLine();
}
else
{
    string steamPath = File.ReadAllText(ToolKit_Data + "/ToolKit.Data.Steam.Path.ini");
    int equalSignIndex = steamPath.IndexOf("=");// 提取等号后的数据
    if (equalSignIndex != -1 && equalSignIndex < steamPath.Length - 1)
    {
        string data = steamPath[(equalSignIndex + 1)..];
    }
    foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.Steam.Path.ini"))
    {
        if (line.Contains("$SteamPath"))
        {
            int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
            if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
            {
                string data = line[(equalSignIndex4 + 1)..];
                File.WriteAllText(ToolKit_App + "/temp/temp.ini", data);
            }
        }
    }
    steamPath = File.ReadAllText(ToolKit_App + "/temp/temp.ini");
    if (File.Exists(steamPath + "/steamapps/common/Half-Life/hl.exe"))
    {
        string HalfLifeApp = Path.Combine(steamPath + "/steamapps/common/Half-Life/hl.exe");
        ToolKit.WriteIniFile(ToolKit_App + "/data/ToolKit.Data.Half-Life.App.ini", "$Half-Life-App", HalfLifeApp);
        Console.WriteLine("已找到游戏App:    " + HalfLifeApp);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error ! Could`t find hl.exe");
        Console.ReadKey();
        Environment.Exit(0);
    }
}

if (File.Exists(ToolKit_Data + "/ToolKit.Data.Half-Life-Path.ini"))
{
    string HalfLifeApp = File.ReadAllText(ToolKit_Data + "/ToolKit.Data.Half-Life.App.ini");
    int equalSignIndex3 = HalfLifeApp.IndexOf("＝");
    if (equalSignIndex3 != -1 && equalSignIndex3 < HalfLifeApp.Length - 1)
    {
        string data = HalfLifeApp[(equalSignIndex3 + 1)..];
    }
    Console.Write("已找到游戏App:    " + HalfLifeApp);
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("按任意键继续...");
    Console.ReadKey();
    Console.ResetColor();
    goto GetApplicationInfo;
}
else
{
    string steamPath = File.ReadAllText(ToolKit_App + "/temp/temp.ini");
    int equalSignIndex = steamPath.IndexOf("=");// 提取等号后的数据
    if (equalSignIndex != -1 && equalSignIndex < steamPath.Length - 1)
    {
        string data = steamPath[(equalSignIndex + 1)..];
    }
    if (File.Exists(steamPath + "/steamapps/common/Half-Life/hl.exe"))
    {
        string HalfLifePath = Path.Combine(steamPath + "/steamapps/common/Half-Life");
        ToolKit.WriteIniFile(ToolKit_App + "/data/ToolKit.Data.Half-Life.Path.ini", "$Half-Life-Path", HalfLifePath);
        Console.WriteLine("已找到游戏路径:    " + HalfLifePath);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error ! Could`t find hl.exe");
        Console.ReadKey();
        Environment.Exit(0);
    }

}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("按任意键继续...");
Console.ReadKey();
Console.ResetColor();
GetApplicationInfo:
Console.Clear();
Console.WriteLine("===============================================================================");
Console.WriteLine("                          GE 工具箱 - 启动");
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine("正在获取GE工具箱数据...");
Console.WriteLine();
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$Version"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("版本:\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$Editor"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("编辑器:\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$Publisher"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Release发布者:\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$Creator"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("项目创建者:\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$TestSystem1"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("测试系统:\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$TestSystem2"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$TestSystem3"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
Console.WriteLine();
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$ScriptLanguage1"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("脚本语言:\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$ScriptLanguage2"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$ScriptLanguage3"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$ScriptLanguage4"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
Console.WriteLine();
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$TextLanguage1"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("文本语言:\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$TextLanguage2"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
Console.WriteLine();
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.App.ini"))
{
    if (line.Contains("$ScriptEncode"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("脚本编码:\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("请按任意键继续...");
Console.ReadKey();
Console.ResetColor();
GetScriptInfo:
Console.Clear();
Console.WriteLine("===============================================================================");
Console.WriteLine("                          GE 工具箱 - 启动");
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine("正在获取脚本数据...");
Console.WriteLine();
string folderPath = ToolKit_App + "/scripts";
string[] jsFiles = Directory.GetFiles(folderPath, "*.js");

if (jsFiles.Length == 1)
{
    string scriptPath = jsFiles[0];
    scriptPath = scriptPath.Replace("\\", "/");
    ToolKit.WriteIniFile(ToolKit_Data + "/ToolKit.Data.github.cdn-download.Path.ini", "$ScriptPath", scriptPath);
}
ToolKit.WriteIniFile(ToolKit_Data + "/ToolKit.Data.github.cdn-download.name.ini", "$ScriptName", "Github Enhancement - High Speed Download");
string scriptPath1 = jsFiles[0];
scriptPath1 = scriptPath1.Replace("\\", "/");
foreach (string line in File.ReadLines(scriptPath1))
{
    if (line.Contains("@version"))
    {
        int equalSignIndex4 = line.IndexOf("      ");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            ToolKit.WriteIniFile(ToolKit_Data + "/ToolKit.Data.github.cdn-download.version.ini", "$ScriptVersion", data);
        }
    }
}
foreach (string line in File.ReadLines(scriptPath1))
{
    if (line.Contains("@author"))
    {
        int equalSignIndex4 = line.IndexOf("       ");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            ToolKit.WriteIniFile(ToolKit_Data + "/ToolKit.Data.github.cdn-download.author.ini", "$ScriptAuthor", data);
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.github.cdn-download.name.ini"))
{
    if (line.Contains("$ScriptName"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("脚本名称:\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.github.cdn-download.version.ini"))
{
    if (line.Contains("$ScriptVersion"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("脚本版本:\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.github.cdn-download.author.ini"))
{
    if (line.Contains("$ScriptAuthor"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("脚本作者:\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.github.cdn-download.language.ini"))
{
    if (line.Contains("$ScriptLanguage"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("脚本语言:\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.github.cdn-download.lines.ini"))
{
    if (line.Contains("$ScriptLine"))
    {
        int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
        if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
        {
            string data = line[(equalSignIndex4 + 1)..];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("可用下载CDN个数:\t\t\t");
            Console.ResetColor();
            Console.Write(data);
            Console.WriteLine();
        }
    }
}
MainMenu:
Console.Title = "MainMenu - GoldSource Engine ToolKit ver " + verShort;
Console.Clear();
Console.WriteLine("===============================================================================");
Console.WriteLine("                          GE 工具箱 - 主  菜  单");
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine("                             [1]   启动游戏");
Console.WriteLine("");
Console.WriteLine("                             [2]   汉化游戏");
Console.WriteLine("");
Console.WriteLine("                             [3]   反    馈");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("                             [4]   自定义键位(不可用 敬请期待)");
Console.ResetColor();
Console.WriteLine();
Console.WriteLine("                             [5]   中英语言切换");
Console.WriteLine("");
Console.WriteLine("                             [6]   更换模型");
Console.WriteLine("");
Console.WriteLine("                             [7]   整合包");
Console.WriteLine("");
Console.WriteLine("                             [8]   更换背景");
Console.WriteLine("");
Console.WriteLine("                             [X]   退出");
Console.WriteLine("");
Console.WriteLine("===============================================================================");
KeyJump3:
ConsoleKeyInfo keyInfo2 = Console.ReadKey(intercept: true);
if (keyInfo2.KeyChar == '1')
{
    goto ChooseGame;
        }
else
{
    if (keyInfo2.KeyChar == '2')
    {
        goto ChineseText;
    }
    if (keyInfo2.KeyChar == '3')
    {
        goto Report;
}
    //if (keyInfo2.KeyChar == '4')
    //{

    //}
    if (keyInfo2.KeyChar == '5')
    {
        goto ChooseSoundLanguage;
    }
    if (keyInfo2.KeyChar == '6')
    {
        goto ChooseModels;
    }
    if (keyInfo2.KeyChar == '7')
    {
        goto AllInOnePack;
    }
    if (keyInfo2.KeyChar == '8')
    {
        goto Background;
    }
    if (keyInfo2.KeyChar == 'x')
    {
        Environment.Exit(0);
    }
    if (keyInfo2.KeyChar == 'X')
    {
        Environment.Exit(0);
    }
    else
    {
        goto KeyJump3;
    }
}
ChooseGame:
Console.Clear();
Console.WriteLine("===============================================================================");
Console.WriteLine("GE 工具箱 - 启动游戏");
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine("选择您游玩的游戏......Console.WriteLine.");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("游玩Half-Life 和 Half-Life:Uplink      输入 [1]");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("游玩Counter-Strike                     输入 [2]");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("===============================================================================");
Console.WriteLine();
KeyJump4:
ConsoleKeyInfo keyInfo4 = Console.ReadKey(intercept: true);
if (keyInfo4.KeyChar == '1')
{
    goto HalfLifeConfig;
}
else
{
    if (keyInfo4.KeyChar == '2')
    {
        goto cstrikeConfig;
    }
    else
    {
        goto KeyJump4;
    }
}


HalfLifeConfig:
Console.Clear();
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine("您已选择了游戏：Half-Life 和 Half-Life:Uplink");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("请选择您要加载的启动项......");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("[1] 更改视角晃动参数( 命令:sv_rollangle, 默认：启用, 等级:2)");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("[2] 快速切枪( 命令:hud_fastswitch, 默认：禁用, 等级:0)");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("[3] 不加载任何启动项, 直接启动游戏");
Console.WriteLine();
Console.WriteLine("===============================================================================");
Console.WriteLine();
KeyJump5:
ConsoleKeyInfo keyInfo5 = Console.ReadKey(intercept: true);
if (keyInfo5.KeyChar == '1')
{
    goto Halflife_sv_rollangle;
}
else
{
    if (keyInfo5.KeyChar == '2')
    {
        goto HalfLife_hud_fastswitch;
    }
    if (keyInfo5.KeyChar == '3')
    {
        goto RunningandEND;
    }
    else
    {
        goto KeyJump5;
    }
}
Halflife_sv_rollangle:
Console.Clear();
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine("===============================================================================");
Console.WriteLine();
if (File.Exists(ToolKit_Data + "/ToolKit.Data.Half-Life-Path.ini"))
{
    string HalfLifePath = File.ReadAllText(ToolKit_Data + "/ToolKit.Data.Half-Life.Path.ini");
    int equalSignIndex2 = HalfLifePath.IndexOf("＝");
    Console.Write("已找到游戏路径:    " + HalfLifePath);
    Console.WriteLine();
}
else
{
    string steamPath = File.ReadAllText(ToolKit_Data + "/ToolKit.Data.Steam.Path.ini");
    int equalSignIndex = steamPath.IndexOf("=");// 提取等号后的数据
    if (equalSignIndex != -1 && equalSignIndex < steamPath.Length - 1)
    {
        string data = steamPath[(equalSignIndex + 1)..];
    }
    foreach (string line in File.ReadLines(ToolKit_Data + "/ToolKit.Data.Steam.Path.ini"))
    {
        if (line.Contains("$SteamPath"))
        {
            int equalSignIndex4 = line.IndexOf("=");// 提取等号后的数据
            if (equalSignIndex4 != -1 && equalSignIndex4 < line.Length - 1)
            {
                string data = line[(equalSignIndex4 + 1)..];
                File.WriteAllText(ToolKit_App + "/temp/temp.ini", data);
            }
        }
    }
    steamPath = File.ReadAllText(ToolKit_App + "/temp/temp.ini");
    if (File.Exists(steamPath + "/steamapps/common/Half-Life/hl.exe"))
    {
        string HalfLifeApp = Path.Combine(steamPath + "/steamapps/common/Half-Life/hl.exe");
        ToolKit.WriteIniFile(ToolKit_App + "/data/ToolKit.Data.Half-Life.App.ini", "$Half-Life-App", HalfLifeApp);
        Console.WriteLine("已找到游戏App:    " + HalfLifeApp);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error ! Could`t find hl.exe");
        Console.ReadKey();
        Environment.Exit(0);
    }
}

HalfLife_hud_fastswitch:
Console.Clear();
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine("===============================================================================");
Console.WriteLine();

RunningandEND:
Console.Clear();
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine("===============================================================================");
Console.WriteLine();

cstrikeConfig:
Console.Clear();
Console.WriteLine("===============================================================================");
Console.WriteLine();
Console.WriteLine("===============================================================================");
Console.WriteLine();

ChineseText:
Console.Clear();
Report:
Console.Clear();
ChooseSoundLanguage:
Console.Clear();
ChooseModels:
Console.Clear();
AllInOnePack:
Console.Clear();
Background:
Console.Clear();