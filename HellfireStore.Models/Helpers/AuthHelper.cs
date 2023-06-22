namespace HellfireStore.Models.Helpers
{
    // Com o modificador de acesso "internal", indicamos que a classe só é acessível no próprio projeto (HellfireStore.Models), mas nunca fora dele (HellfireStore.Terminal)
    internal class AuthHelper
    {
        public bool ComparePasswd (string truePasswd, string Passwd) { 
            return truePasswd == Passwd;
        }
    }
}
