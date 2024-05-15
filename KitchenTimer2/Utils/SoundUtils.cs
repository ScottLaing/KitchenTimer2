using System.Media;

namespace KitchenTimer.Utils
{
    public class SoundUtils
    {
        /// <summary>
        /// Loads a wave file from the embedded resources and assigns it to the specified SoundPlayer.
        /// </summary>
        /// <param name="alarmName">The name of the wave file without the file extension.</param>
        /// <param name="player">The SoundPlayer to assign the loaded wave file to.</param>
        public static void LoadWaveFile(string alarmName, SoundPlayer player)
        {
            //get the current assembly
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            //load the embedded resource as a stream
            var file = $"{alarmName}.wav";
            var stream = assembly.GetManifestResourceStream(string.Format("{0}.Resources.{1}", assembly.GetName().Name, file));

            //load the stream into the player
            player = new SoundPlayer(stream);

            // Load the .wav file.
            player.Load();
        }
    }
}
