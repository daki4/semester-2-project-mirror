namespace DesktopApplication
{
    public static class SendTextToGui
    {
        public static event EventHandler<TextTransferEventArgs>? TextReceived;

        public static void RaiseTextReceivedEvent(object sender, TextTransferEventArgs text)
        {
            var handler = TextReceived;
            handler?.Invoke(sender, text);
        }
    }
}
