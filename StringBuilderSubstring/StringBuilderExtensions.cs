using System.Text;

namespace StringBuilderSubstring
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder @this, int startIndex)
        {
            if (@this.ToString() == "")
                return new StringBuilder();

            StringBuilder sb = new StringBuilder();
            sb.Append(@this.ToString().Substring(startIndex));
            return sb;
        }

        public static StringBuilder Substring(this StringBuilder @this, int startIndex, int length)
        {
            if (@this.ToString() == "")
                return new StringBuilder();

            StringBuilder sb = new StringBuilder();
            sb.Append(@this.ToString(), startIndex, length);
            return sb;
        }

    }
}
