// Upgrade NOTE: upgraded instancing buffer 'Props' to new syntax.

Shader "PeerPlay/SphericalMask Opacity Clip" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_ColorStrength("Color Strength", Range(1,4)) = 1
		_EmissionColor ("Emission Color", Color) = (1,1,1,1)
		_EmissionTex ("Emission (RGB)", 2D) = "white" {}
		_EmissionStrength("Emission Strength", Range(0,4)) = 1
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
	}
	SubShader {
		Tags { "RenderType"="Transparent" "Queue"="Geometry-1" }
		LOD 200
		
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

		sampler2D _MainTex, _EmissionTex;

		struct Input {
			float2 uv_MainTex;
			float2 uv_EmissionTex;
			float3 worldPos;
		};

		half _Glossiness;
		half _Metallic;
		fixed4 _Color, _EmissionColor;
		half _ColorStrength, _EmissionStrength;

		//Spherical Mask
		uniform float4 GLOBALmask_Position;
		uniform half GLOBALmask_Radius;
		

		// Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
		// See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
		// #pragma instancing_options assumeuniformscaling
		UNITY_INSTANCING_BUFFER_START(Props)
			// put more per-instance properties here
		UNITY_INSTANCING_BUFFER_END(Props)

		void surf (Input IN, inout SurfaceOutputStandard o) {
			//Color
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color * _ColorStrength;
			//Emission
			fixed4 e = tex2D(_EmissionTex, IN.uv_EmissionTex) * _EmissionColor * _EmissionStrength;

			//Opacity Clipping Sphere Mask
			float d_clip = distance(IN.worldPos, GLOBALmask_Position) - GLOBALmask_Radius;

			o.Albedo = c.rgb;
			// Metallic and smoothness come from slider variables
			o.Metallic = _Metallic;
			o.Emission = e.rgb;
			o.Smoothness = _Glossiness;
			o.Alpha = c.a;
			//Clip the opacity
			clip(float3(-d_clip,-d_clip,-d_clip));
		}
		ENDCG
	}
	Fallback "Transparent/Cutout/Diffuse"
}