﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis.CSharp;

namespace UnityEngine.Rendering.UIGen
{
    public class BindableView
    {
        XmlDocument m_Uxml;
        CSharpSyntaxTree m_BindingCode;
    }

    public static class BindableViewExtensions
    {
        public struct DiskLocation
        {
            string assetLocation;
            string runtimeCodeLocation;
            string editorCodeLocation;
        }

        // Consider async API?
        [MustUseReturnValue]
        public static bool WriteToDisk(
            [DisallowNull] this BindableView view,
            DiskLocation location,
            [NotNullWhen(false)] out Exception error
        )
        {
            throw new NotImplementedException();
        }
    }
}
