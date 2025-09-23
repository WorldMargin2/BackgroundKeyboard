using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KeysBinding {


    internal class KeysBinding {
        public static readonly Dictionary<String, Keys> KeyNames = new Dictionary<string, Keys> {
            {"None",0 },
            {"LButton",Keys.LButton },
            {"RButton",Keys.RButton },
            {"Cancel",Keys.Cancel },
            {"MButton",Keys.MButton },
            {"XButton1",Keys.XButton1 },
            {"XButton2",Keys.XButton2 },
            {"Back",Keys.Back },
            {"Tab",Keys.Tab },
            {"LineFeed",Keys.LineFeed },
            {"Clear",Keys.Clear },
            {"Return",Keys.Return },
            {"Enter",Keys.Enter },
            {"ShiftKey",Keys.ShiftKey },
            {"ControlKey",Keys.ControlKey },
            {"Menu",Keys.Menu },
            {"Pause",Keys.Pause },
            {"Capital",Keys.Capital },
            {"CapsLock",Keys.CapsLock },
            {"KanaMode",Keys.KanaMode },
            {"HanguelMode",Keys.HanguelMode },
            {"HangulMode",Keys.HangulMode },
            {"JunjaMode",Keys.JunjaMode },
            {"FinalMode",Keys.FinalMode },
            {"HanjaMode",Keys.HanjaMode },
            {"KanjiMode",Keys.KanjiMode },
            {"Escape",Keys.Escape },
            {"IMEConvert",Keys.IMEConvert },
            {"IMENonconvert",Keys.IMENonconvert },
            {"IMEAccept",Keys.IMEAccept },
            {"IMEAceept",Keys.IMEAceept },
            {"IMEModeChange",Keys.IMEModeChange },
            {"Space",Keys.Space },
            {"Prior",Keys.Prior },
            {"PageUp",Keys.PageUp },
            {"Next",Keys.Next },
            {"PageDown",Keys.PageDown },
            {"End",Keys.End },
            {"Home",Keys.Home },
            {"Left",Keys.Left },
            {"Up",Keys.Up },
            {"Right",Keys.Right },
            {"Down",Keys.Down },
            {"Select",Keys.Select },
            {"Print",Keys.Print },
            {"Execute",Keys.Execute },
            {"Snapshot",Keys.Snapshot },
            {"PrintScreen",Keys.PrintScreen },
            {"Insert",Keys.Insert },
            {"Delete",Keys.Delete },
            {"Help",Keys.Help },
            {"D0",Keys.D0 },
            {"D1",Keys.D1 },
            {"D2",Keys.D2 },
            {"D3",Keys.D3 },
            {"D4",Keys.D4 },
            {"D5",Keys.D5 },
            {"D6",Keys.D6 },
            {"D7",Keys.D7 },
            {"D8",Keys.D8 },
            {"D9",Keys.D9 },
            {"A",Keys.A },
            {"B",Keys.B },
            {"C",Keys.C },
            {"D",Keys.D },
            {"E",Keys.E },
            {"F",Keys.F },
            {"G",Keys.G },
            {"H",Keys.H },
            {"I",Keys.I },
            {"J",Keys.J },
            {"K",Keys.K },
            {"L",Keys.L },
            {"M",Keys.M },
            {"N",Keys.N },
            {"O",Keys.O },
            {"P",Keys.P },
            {"Q",Keys.Q },
            {"R",Keys.R },
            {"S",Keys.S },
            {"T",Keys.T },
            {"U",Keys.U },
            {"V",Keys.V },
            {"W",Keys.W },
            {"X",Keys.X },
            {"Y",Keys.Y },
            {"Z",Keys.Z },
            {"LWin",Keys.LWin },
            {"RWin",Keys.RWin },
            {"Apps",Keys.Apps },
            {"Sleep",Keys.Sleep },
            {"NumPad0",Keys.NumPad0 },
            {"NumPad1",Keys.NumPad1 },
            {"NumPad2",Keys.NumPad2 },
            {"NumPad3",Keys.NumPad3 },
            {"NumPad4",Keys.NumPad4 },
            {"NumPad5",Keys.NumPad5 },
            {"NumPad6",Keys.NumPad6 },
            {"NumPad7",Keys.NumPad7 },
            {"NumPad8",Keys.NumPad8 },
            {"NumPad9",Keys.NumPad9 },
            {"Multiply",Keys.Multiply },
            {"Add",Keys.Add },
            {"Separator",Keys.Subtract},
            {"Subtract",Keys.Subtract },
            {"Decimal",Keys.Decimal },
            {"Divide",Keys.Divide },
            {"F1",Keys.F1 },
            {"F2",Keys.F2 },
            {"F3",Keys.F3 },
            {"F4",Keys.F4 },
            {"F5",Keys.F5 },
            {"F6",Keys.F6 },
            {"F7",Keys.F7 },
            {"F8",Keys.F8 },
            {"F9",Keys.F9 },
            {"F10",Keys.F10 },
            {"F11",Keys.F11 },
            {"F12",Keys.F12 },
            {"F13",Keys.F13 },
            {"F14",Keys.F14 },
            {"F15",Keys.F15 },
            {"F16",Keys.F16 },
            {"F17",Keys.F17 },
            {"F18",Keys.F18 },
            {"F19",Keys.F19 },
            {"F20",Keys.F20 },
            {"F21",Keys.F21 },
            {"F22",Keys.F22 },
            {"F23",Keys.F23 },
            {"F24",Keys.F24 },
            {"NumLock",Keys.NumLock },
            {"Scroll",Keys.Scroll },
            {"LShiftKey",Keys.LShiftKey },
            {"RShiftKey",Keys.RShiftKey },
            {"LControlKey",Keys.LControlKey },
            {"RControlKey",Keys.RControlKey },
            {"LMenu",Keys.LMenu },
            {"RMenu",Keys.RMenu },
            {"BrowserBack",Keys.BrowserBack },
            {"BrowserForward",Keys.BrowserForward },
            {"BrowserRefresh",Keys.BrowserRefresh },
            {"BrowserStop",Keys.BrowserStop },
            {"BrowserSearch",Keys.BrowserSearch },
            {"BrowserFavorites",Keys.BrowserFavorites },
            {"BrowserHome",Keys.BrowserHome },
            {"VolumeMute",Keys.VolumeMute },
            {"VolumeDown",Keys.VolumeDown },
            {"VolumeUp",Keys.VolumeUp },
            {"MediaNextTrack",Keys.MediaNextTrack },
            {"MediaPreviousTrack",Keys.MediaPreviousTrack },
            {"MediaStop",Keys.MediaStop },
            {"MediaPlayPause",Keys.MediaPlayPause },
            {"LaunchMail",Keys.LaunchMail },
            {"SelectMedia",Keys.SelectMedia },
            {"LaunchApplication1",Keys.LaunchApplication1 },
            {"LaunchApplication2",Keys.LaunchApplication2 },
            {"Oem1",Keys.Oem1 },
            {"OemPlus",Keys.Oemplus },
            {"OemComma",Keys.Oemcomma },
            {"OemMinus",Keys.OemMinus },
            {"OemPeriod",Keys.OemPeriod },
            {"Oem2",Keys.Oem2 },
            {"Oem3",Keys.Oem3 },
            {"Oem4",Keys.Oem4 },
            {"Oem5",Keys.Oem5 },
            {"Oem6",Keys.Oem6 },
            {"Oem7",Keys.Oem7 },
            {"Oem8",Keys.Oem8 },
            {"Oem102",Keys.Oem102 },
            {"ProcessKey",Keys.ProcessKey },
            {"Packet",Keys.Packet },
            {"Attn",Keys.Attn },
            {"CrSel",Keys.Crsel },
            {"ExSel",Keys.Exsel },
            {"EraseEof",Keys.EraseEof },
            {"Play",Keys.Play },
            {"Zoom",Keys.Zoom },
            {"NoName",Keys.NoName },
            {"Pa1",Keys.Pa1 },
            {"OemClear",Keys.OemClear },
            {"Shift",Keys.Shift },
            {"Control",Keys.Control },
            {"Alt",Keys.Alt }
        };

        public static readonly Dictionary<Keys, String> reverseKeyNames = KeyNames
            .GroupBy(e => e.Value)
            .ToDictionary(g => g.First().Value, g => g.First().Key);


        //错误管理

        private List<string> errorCode = new List<string> {
            "主控键与副键相同",
            "主控键错误(Ctrl,Alt,Shift)",
            "副键错误",
            "键组已注册",
            "键组未注册",
            "函数未注册"
        };

        public string getError(int err) {
            if (err == 100) return "";
            return errorCode[err];
        }
        //注册键组

        //  键组结构体
        public struct KeyFunction {
            public KeyFunction(Keys modifier, Keys key) {
                this.modifier = modifier;
                this.key = key;
            }
            public Keys modifier;
            public Keys key;
        }
        //  函数-键组字典
        private Dictionary<Action, KeyFunction> registedKeys = new Dictionary<Action, KeyFunction> { };
        //  键组-函数字典（Ctrl, Alt, Shift，None）

        private Dictionary<Keys, Dictionary<Keys, Action>> registedFunctions = new Dictionary<Keys, Dictionary<Keys, Action>> {
            {Keys.Control,new Dictionary<Keys, Action>{ } },
            {Keys.Alt,new Dictionary<Keys, Action>{ } },
            {Keys.Shift,new Dictionary<Keys, Action>{ } },
            {Keys.None,new Dictionary<Keys, Action>{ } },
        };

        //键组管理


        public KeyFunction getKey(Action function) {
            if (!registedKeys.ContainsKey(function)) {
                return new KeyFunction(Keys.None, Keys.None);
            }
            return registedKeys[function];
        }

        public int registKeyFunction(Keys modifier, Keys key, Action function,bool Forced=false) {
            if (modifier == key) {
                return 0;
            } else if (!registedFunctions.ContainsKey(modifier) ) {
                return 1;
            } else if (key != Keys.None && !reverseKeyNames.ContainsKey(key)) {
                return 2;
            } else if (registedFunctions[modifier].ContainsKey(key) && !Forced) {
                return 3;
            }

            registedFunctions[modifier].Add(key, function);
            if (registedKeys.ContainsKey(function)) {
                KeyFunction tmp = registedKeys[function];
                registedFunctions[tmp.modifier].Remove(tmp.key);
            }
            registedKeys[function] = new KeyFunction(modifier, key);


            return 100;
        }

        //========================================================================
        public int removeKeyFunction(Keys modifier, Keys key) {
            if (modifier == key) {
                return 0;
            } else if (!registedFunctions.ContainsKey(modifier)) {
                return 1;
            } else if (key != Keys.None && registedFunctions[modifier].ContainsKey(key)) {
                return 2;
            } else if (!registedFunctions[modifier].ContainsKey(key)) {
                return 4;
            }

            Action f = registedFunctions[modifier][key];
            registedFunctions[modifier].Remove(key);
            registedKeys.Remove(f);

            return 100;
        }

        //  重载
        public int removeKeyFunction(Action function) {
            if (!registedKeys.ContainsKey(function)) return 5;
            KeyFunction f = registedKeys[function];
            registedKeys.Remove(function);
            registedFunctions[f.modifier].Remove(f.key);
            return 100;
        }
        //========================================================================


        //事件处理
        public bool handleKeyFunction(Keys modifier, Keys key) {
            if (!registedFunctions[modifier].ContainsKey(key)) {
                return false;
            }
            registedFunctions[modifier][key]();
            //MessageBox.Show(modifier.ToString(),key.ToString());
            return true;
        }
    }
}
