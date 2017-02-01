using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace UnityEngine.Experimental.Rendering.HDPipeline
{
    [Serializable]
    public class GlobalDebugParameters
    {
        public float debugOverlayRatio = 0.33f;
        public bool displayDebug = false;
        public bool displayShadowDebug = false;

        public ShadowDebugParameters shadowDebugParameters = new ShadowDebugParameters();
    }

    public class DebugParameters
    {
        // Material Debugging
        public int debugViewMaterial = 0;

        // Rendering debugging
        public bool displayOpaqueObjects = true;
        public bool displayTransparentObjects = true;

        public bool useForwardRenderingOnly = false; // TODO: Currently there is no way to strip the extra forward shaders generated by the shaders compiler, so we can switch dynamically.
        public bool useDepthPrepass = false;
        public bool useDistortion = true;

        // we have to fallback to forward-only rendering when scene view is using wireframe rendering mode --
        // as rendering everything in wireframe + deferred do not play well together
        public bool ShouldUseForwardRenderingOnly() { return useForwardRenderingOnly || GL.wireframe; }
    }

    public enum ShadowDebugMode
    {
        None,
        VisualizeAtlas,
        VisualizeShadowMap
    }

    [Serializable]
    public class ShadowDebugParameters
    {
        public bool             enableShadows = true;
        public ShadowDebugMode  visualizationMode = ShadowDebugMode.None;
        public uint             visualizeShadowMapIndex = 0;
    }
}
