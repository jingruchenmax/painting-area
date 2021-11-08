
Shader "Unlit/SimpleBlend"
{
    Properties
    {
        _BackTex("Back(Main) Texture (RGB)", 2D) = "white" {}
        _FrontTex("Front Texture (RGB) Transparent (A)", 2D) = "white" {}
        _Blend("Blend", Range(0,1)) = 0.5
    }

        SubShader
        {
            Tags{ "Queue" = "Transparent" "RenderType" = "Transparent" }
            LOD 200
            ZWrite Off

            CGPROGRAM

    #pragma surface surf Lambert

            sampler2D _BackTex;
            sampler2D _FrontTex;
            float _Blend;


            struct Input
            {
                float2 uv_BackTex;
                float2 uv_FrontTex;
            };

            void surf(Input IN, inout SurfaceOutput o)
            {
                fixed4 backTex = tex2D(_BackTex, IN.uv_BackTex);
                fixed4 frontTex = tex2D(_FrontTex, IN.uv_FrontTex);

                fixed4 mainOutput = backTex.rgba * (1.0 - (frontTex.a * _Blend));
                fixed4 combineOutput = frontTex.rgba * (frontTex.a * _Blend);

                o.Albedo = mainOutput.rgb + combineOutput.rgb;
                o.Alpha = mainOutput.a + combineOutput.a;
            }

            ENDCG
        }

            FallBack "Diffuse"
}