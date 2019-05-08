namespace AngleSharp.Css.Values
{
    using AngleSharp.Text;
    using System;

    sealed class CssCustomCursorValue : ICssCompositeValue
    {
        public ICssImageValue Source;
        public Point? Position;

        /// <summary>
        /// Gets the CSS text representation.
        /// </summary>
        public String CssText
        {
            get
            {
                var sb = StringBuilderPool.Obtain();

                sb.Append(Source.CssText);

                if (Position.HasValue)
                {
                    sb.Append(Symbols.Space);
                    sb.Append(Position.Value.CssText);
                }

                return sb.ToPool();
            }
        }
    }
}
