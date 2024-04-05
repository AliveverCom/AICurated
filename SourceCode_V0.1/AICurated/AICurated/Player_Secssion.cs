using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace AICurated
{
    /// <summary>
    /// play a secssion
    /// </summary>
    public class Player_Secssion
    {
        static void read()
        {
            // 创建语音合成器实例
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                // 列出所有安装的语音引擎
                foreach (var voice in synthesizer.GetInstalledVoices())
                {
                    Console.WriteLine($"Voice: {voice.VoiceInfo.Name}, Culture: {voice.VoiceInfo.Culture}");
                }

                // 设置朗读英文的语音包
                synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.NotSet, 0, new System.Globalization.CultureInfo("en-US"));
                // 朗读英文文本
                Console.WriteLine("Reading in English...");
                synthesizer.Speak("Hello, this is a test of the English text-to-speech engine in Windows 11.");

                // 设置朗读中文的语音包
                synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.NotSet, 0, new System.Globalization.CultureInfo("zh-CN"));
                // 朗读中文文本
                Console.WriteLine("正在中文朗读...");
                synthesizer.Speak("你好，这是在 Windows 11 中测试中文文本到语音引擎的示例。");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
