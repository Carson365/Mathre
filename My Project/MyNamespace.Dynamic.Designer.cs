using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Mathre.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmMathre m_FrmMathre;

            public FrmMathre FrmMathre
            {
                [DebuggerHidden]
                get
                {
                    m_FrmMathre = Create__Instance__(m_FrmMathre);
                    return m_FrmMathre;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmMathre))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmMathre);
                }
            }
        }
    }
}