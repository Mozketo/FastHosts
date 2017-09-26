namespace FastHosts.Infrastructure.Ext
{
    public static class StringEx
    {
        public static int CountChar(this string source, char chr)
        {
            int count = 0;
            foreach (var c in source)
            {
                if (c == chr) count++;
            }
            return count;
        }
    }
}
