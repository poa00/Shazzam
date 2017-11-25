﻿// ReSharper disable InconsistentNaming
// ReSharper disable ArrangeThisQualifier
#pragma warning disable SA1101 // Prefix local calls with this
#pragma warning disable SA1300 // Element must begin with upper-case letter
#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable SA1400 // Access modifier must be declared
namespace ShazzamUnitTests.Sandbox
{
    using NUnit.Framework;
    using static Hlsl.Types;

    internal class LerpRgbaTests : Hlsl
    {
        [TestCase("#FFFF0000", "#00FFFFFF", 0, "#FFFF0000")]
        [TestCase("#FFFF0000", "#00FFFFFF", 1, "#00FFFFFF")]
        public void Test(string x, string y, float s, string expected)
        {
            Assert.Inconclusive("Fix this");
            //Assert.AreEqual(expected, lerp_rgba(float4(x), Parse(y), s));
        }

        float4 lerp_rgba(float4 x, float4 y, float s)
        {
            float a = lerp(x.a, y.a, s);
            float3 rgb = lerp(x.rgb, y.rgb, s) * a;
            return float4(rgb.r, rgb.g, rgb.b, a);
        }
    }
}