Shader "Custom/Fire 1" {
	Properties {
		_Noise1Tex("Noise_1",2D) = "White"{}
		_Noise2Tex("Noise_2",2D) = "White"{}
		_GrTex("Gradient",2D) = "White"{}
		shikichi("しきい値",Range(0,1)) = 0
		effect("影響力",Range(0.1,0.9)) = 0
		_Color("炎色",Color)=(1,1,1,1)
		offsetx("xoffset",range(0,1))=0
		offsety("yoffset",range(0,1))=0
		als("toumeido",range(0,1))=0
	}
	SubShader {
		Tags 
		{ 
		  "Queue" = "Transparent"
	      "RenderType" = "Transparent"
		  
		 }

		LOD 200
		Cull off


		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows alpha:fade

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

		sampler2D _Noise1Tex;
		sampler2D _Noise2Tex;
		sampler2D _GrTex;
		
		float als;
		fixed4 _Color;

		fixed ns=2;
		float shikichi;
		float effect;

		float offsetx;
		float offsety;


		struct Input {
			float2 uv_Noise1Tex;
			float2 uv_Noise2Tex;
			float2 uv_GrTex;
		};

		UNITY_INSTANCING_BUFFER_START(Props)
			
		UNITY_INSTANCING_BUFFER_END(Props)

		
		//--- グレースケールに変換する関数
		fixed sGscale(fixed4 p)
		{
			return fixed(p.r * 0.3 + p.g * 0.6 + p.b * 0.1);
		}

		void surf (Input IN, inout SurfaceOutputStandard o) {
			fixed2 uvn1 = IN.uv_Noise1Tex;
			   uvn1.y -= _Time * 2 - offsety;
			fixed2 uvn2 = IN.uv_Noise2Tex;
			   uvn2.y -= _Time * 4 - offsety;
			fixed2 uvn3 = IN.uv_GrTex;
			   uvn3 = uvn3 * 0.5;
			   

			//--- 各テクスチャの色をグレースケールに変換する

			fixed gn1 = sGscale(tex2D(_Noise1Tex,uvn1));
			fixed gn2 = sGscale(tex2D(_Noise2Tex,uvn2));
			fixed gn3 = sGscale(tex2D(_GrTex,uvn3));

			if(gn1 * gn2 * (gn3) > shikichi){
			o.Albedo = fixed4(_Color.r,_Color.g,_Color.b,0);
			o.Alpha = als;
			}else{
			o.Alpha = 0;
			}
			o.Emission = (1,1,1,1)*0.3;
			
			
		}

		ENDCG
	}
	FallBack "Diffuse"
}

