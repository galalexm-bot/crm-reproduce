using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Components;

[Component]
public class RelationshipMetadataFormTransformation : IEntityMetadataFormTransformation
{
	private readonly Dictionary<Guid, Guid> transformationGuids = new Dictionary<Guid, Guid>
	{
		{
			new Guid("66a467b5-f724-4f56-b390-012ce2828e99"),
			new Guid("86d4c3d2-4e63-4225-a2bd-73f09c24927f")
		},
		{
			new Guid("880ed788-c633-47ab-86a3-b2dfe3b01df5"),
			new Guid("dff5a545-34a6-4ff0-9484-d81de10ce39e")
		},
		{
			new Guid("4e260af3-63be-4bc8-a77c-3bf7f335f118"),
			new Guid("30d3fdb3-8949-4ed5-a55b-edc06706194e")
		},
		{
			new Guid("e18c846b-f866-43a1-a7ad-70f3fc392960"),
			new Guid("d942d4cf-a55c-49b3-a794-917f4195e836")
		},
		{
			new Guid("68fd73c7-9586-4765-b9c7-24d2acf616a0"),
			new Guid("50d59485-f69b-4e4b-b015-7beaece05bff")
		},
		{
			new Guid("e89eea0e-a463-4e20-a20b-c8febb702ac7"),
			new Guid("712c41a3-ea86-4e5b-b6bf-7adf54eef71c")
		},
		{
			new Guid("db3a1820-1b06-40fc-aa07-d955b668e2a3"),
			new Guid("795782dd-3d99-458f-b6da-c3a220efb7e0")
		},
		{
			new Guid("592ab8cd-f4b9-472a-a22e-860715b9ee3a"),
			new Guid("4bf6526f-4a61-4ec7-90f7-cf2a994fedbc")
		},
		{
			new Guid("f41bed46-472f-47b3-a27a-99a37fee9bd5"),
			new Guid("673068dc-1065-474c-80d6-cf2e7b64fad7")
		},
		{
			new Guid("1b7454b7-e723-45c6-ba05-2b97588ad461"),
			new Guid("4704f538-d6d1-47bd-b009-c5649320fd98")
		},
		{
			new Guid("e5ec5c50-1baf-405b-880b-b995a29100a4"),
			new Guid("ed12cbac-0972-45a2-a429-b2300d67e3a8")
		},
		{
			new Guid("950b6634-84fe-4b0e-a88a-dfd54d24c95c"),
			new Guid("a820b365-1763-4d4a-9fae-44325038c021")
		},
		{
			new Guid("8bc6bc04-5429-424a-9de2-dcbaa7815cdf"),
			new Guid("98a03366-e22d-402b-bd87-3d0ac7456dc4")
		},
		{
			new Guid("52ff5639-2292-45fe-9cc6-1881c9895d13"),
			new Guid("53217522-dd6a-41fa-9e1f-45e5a1a80b68")
		},
		{
			new Guid("b29f3420-f764-4751-977d-aff6236dfd9d"),
			new Guid("4c2cab91-25e6-46c0-b4c2-75fa4cd2c50f")
		},
		{
			new Guid("48825f29-4a1c-4a77-9b6a-d2188f95aa62"),
			new Guid("124482d3-b718-4820-ad8b-2eeaa4d1153e")
		},
		{
			new Guid("18f14693-dbb8-46ac-b7e2-0e90a1b7e6b7"),
			new Guid("2f858a24-e177-4af7-a40c-66b20e501c09")
		},
		{
			new Guid("2814b916-ec96-4abe-abf1-dd684ec895e7"),
			new Guid("7ce0faad-563a-4d09-9ccd-a15a33aac5a9")
		},
		{
			new Guid("d7f9efa4-4bc3-4fec-9c8a-39529ae578c1"),
			new Guid("643f0b45-cb5c-42a8-a8c2-9cc06a049816")
		},
		{
			new Guid("8cb5eae0-54eb-4530-a716-4fa7370f548a"),
			new Guid("720463da-5537-42c7-9bf2-6442dde1826d")
		},
		{
			new Guid("e2fb1211-36f0-4253-a29f-823922860966"),
			new Guid("3c649a1a-346d-45e3-9636-4358c7090bac")
		},
		{
			new Guid("31e0ba99-9a33-4541-a358-d18f3db2910e"),
			new Guid("af4739c6-0f00-4715-970d-0d0f0f646960")
		},
		{
			new Guid("3897914b-8508-4840-b2cb-025f869989db"),
			new Guid("b501260e-a416-4dcf-b182-9ea0bf75ff4c")
		},
		{
			new Guid("599e07e8-62a6-48a9-b93d-52cd3a8c5242"),
			new Guid("3c649a1a-346d-45e3-9636-4358c7090bac")
		},
		{
			new Guid("763f16e8-a96e-45d0-90b5-020a06ef12fc"),
			new Guid("03b37727-d86f-4b31-b1d1-06e4c1723176")
		},
		{
			new Guid("1c427170-3583-4abe-b756-1d15d7bd1f7e"),
			new Guid("d02dfe9c-bad2-4a9e-bd1b-0be6bca3b198")
		},
		{
			new Guid("36b300f0-52f1-446f-acf1-4f4ee8b448d9"),
			new Guid("85ffb842-91a9-445d-b9ac-46caada9b6e7")
		},
		{
			new Guid("dea9618a-5860-41d0-ba8f-a66f9d7231cd"),
			new Guid("8a367061-9297-4e55-a2c0-a5ad7bce3e37")
		},
		{
			new Guid("afffe732-3b49-4c2d-988a-c266777521de"),
			new Guid("0bc505fe-d6f0-4b28-a257-0168cea07828")
		},
		{
			new Guid("b0892c6d-36e1-44d0-89a3-08753e69720d"),
			new Guid("ef4759d6-c90d-444a-b0fb-bad0c20f8c1a")
		},
		{
			new Guid("dd5b9167-5086-43b4-a722-929c635db0b9"),
			new Guid("59db97d5-9133-4504-b571-8b8cf5cc0961")
		},
		{
			new Guid("b24e2e65-1c2a-4362-a5b0-4a457230d650"),
			new Guid("c6969fc9-cf55-4192-92f6-095b23209486")
		},
		{
			new Guid("bba539fd-1134-449f-9536-da5cbafd295b"),
			new Guid("711286f7-a0f3-4439-a737-cdb863ad5a1f")
		},
		{
			new Guid("3190eb2e-c7a6-43e2-a9cc-f1a318b7ddb6"),
			new Guid("5fe3948c-b5a7-4bf2-bada-d0e35f762884")
		},
		{
			new Guid("a6d1fab2-aaff-4a4e-a9f8-de0671de8c5c"),
			new Guid("af535cc4-e980-4e8d-addd-1279a602c050")
		},
		{
			new Guid("8a58e9f7-f00e-4098-ad30-18bb7bdf3ab2"),
			new Guid("ae053a00-8376-43c3-a2cf-cc9fb96e6478")
		},
		{
			new Guid("c7f5a63a-770a-444a-8fa5-04feb37490d9"),
			new Guid("c05876f3-c5a0-4266-b24f-325be94ce0d1")
		},
		{
			new Guid("d48d2440-82da-42fd-9c64-9fa49b6c36c2"),
			new Guid("2b17e1ee-6587-4097-acfa-450991ed5000")
		},
		{
			new Guid("acf2885c-41aa-4720-8bbd-d3233695baf2"),
			new Guid("1379b0ea-2f21-47cb-84ad-1a8d3b23a988")
		},
		{
			new Guid("40e9b651-ba70-4e1f-8897-e5d5c1c7ec6b"),
			new Guid("63394f61-403d-40fb-b36b-3efe6efab838")
		},
		{
			new Guid("58c68606-acd0-4a5c-965b-bcb77a10a14c"),
			new Guid("516431c1-90bd-4973-8769-11566af848df")
		},
		{
			new Guid("41cb24cc-5acb-420a-b3b7-c88779bbbb2e"),
			new Guid("065623e0-8244-4b6b-ba9f-b811c3bf5b3c")
		},
		{
			new Guid("1d17e027-df18-4143-899b-c43ca23ffa65"),
			new Guid("1b7360d8-db68-495e-aaeb-5b5be03ecb93")
		},
		{
			new Guid("21bb3a6a-dadb-46a1-ba71-b79941803709"),
			new Guid("685a94c7-3f45-439f-8db1-c0feabab145c")
		},
		{
			new Guid("7ad1ad45-d76e-4c8c-82b1-40e9170bd85f"),
			new Guid("86d4c3d2-4e63-4225-a2bd-73f09c24927f")
		},
		{
			new Guid("c39a7ccd-63d1-46aa-805f-79a5ac5f2852"),
			new Guid("dff5a545-34a6-4ff0-9484-d81de10ce39e")
		},
		{
			new Guid("c17e8fae-487c-4d0b-84c4-af3f3badc8c2"),
			new Guid("30d3fdb3-8949-4ed5-a55b-edc06706194e")
		},
		{
			new Guid("2527de55-e1fe-4052-b1d3-d26de0cc528d"),
			new Guid("d942d4cf-a55c-49b3-a794-917f4195e836")
		},
		{
			new Guid("8e83f24e-ca0e-460c-a5ba-26f56f3a70dc"),
			new Guid("50d59485-f69b-4e4b-b015-7beaece05bff")
		},
		{
			new Guid("fea773e1-4b39-450e-8bd8-894dbddedc23"),
			new Guid("712c41a3-ea86-4e5b-b6bf-7adf54eef71c")
		},
		{
			new Guid("66dcc76f-ea62-418b-be4d-bfbbebfeb729"),
			new Guid("795782dd-3d99-458f-b6da-c3a220efb7e0")
		},
		{
			new Guid("bbb987db-a992-4e54-bcdf-48465fe7b0bb"),
			new Guid("4bf6526f-4a61-4ec7-90f7-cf2a994fedbc")
		},
		{
			new Guid("acf6b637-584d-47d1-9890-6063629765df"),
			new Guid("673068dc-1065-474c-80d6-cf2e7b64fad7")
		},
		{
			new Guid("b63d265d-df3f-41fe-befa-6b9eb142661d"),
			new Guid("4704f538-d6d1-47bd-b009-c5649320fd98")
		},
		{
			new Guid("e0c8b7ef-701b-4d70-969e-280da6332924"),
			new Guid("ed12cbac-0972-45a2-a429-b2300d67e3a8")
		},
		{
			new Guid("651258d8-d87b-4e12-8754-50b8c1d349d5"),
			new Guid("a820b365-1763-4d4a-9fae-44325038c021")
		},
		{
			new Guid("43f688cd-6a6d-462a-9232-bdb37ead694e"),
			new Guid("98a03366-e22d-402b-bd87-3d0ac7456dc4")
		},
		{
			new Guid("e736f077-a104-4c91-9df0-b33cf77c9db4"),
			new Guid("53217522-dd6a-41fa-9e1f-45e5a1a80b68")
		},
		{
			new Guid("11660f3f-4cd6-41b9-942d-62197bd97299"),
			new Guid("4c2cab91-25e6-46c0-b4c2-75fa4cd2c50f")
		},
		{
			new Guid("723dad2a-5745-48bf-9e06-4642f4285a53"),
			new Guid("124482d3-b718-4820-ad8b-2eeaa4d1153e")
		},
		{
			new Guid("c844db9e-e2cd-4c55-a675-25641308a611"),
			new Guid("2f858a24-e177-4af7-a40c-66b20e501c09")
		},
		{
			new Guid("cad3a124-6bb9-4d42-a92e-10e165b8d855"),
			new Guid("7ce0faad-563a-4d09-9ccd-a15a33aac5a9")
		},
		{
			new Guid("9de95c44-90bc-49ed-8f7d-6a8b3e44ac59"),
			new Guid("643f0b45-cb5c-42a8-a8c2-9cc06a049816")
		},
		{
			new Guid("1616401d-7544-4a30-b02c-0fce139f257f"),
			new Guid("720463da-5537-42c7-9bf2-6442dde1826d")
		},
		{
			new Guid("23d11359-fe48-48fa-a2f6-9e7a697f9ecf"),
			new Guid("3c649a1a-346d-45e3-9636-4358c7090bac")
		},
		{
			new Guid("450d8dfe-b1ef-4294-b1e6-baefa2f9928f"),
			new Guid("af4739c6-0f00-4715-970d-0d0f0f646960")
		},
		{
			new Guid("6b5db43e-04a3-463a-8bd9-3d3c0a85f103"),
			new Guid("b501260e-a416-4dcf-b182-9ea0bf75ff4c")
		},
		{
			new Guid("02b35c2a-3b0f-4802-b563-9115b645a56f"),
			new Guid("3c649a1a-346d-45e3-9636-4358c7090bac")
		},
		{
			new Guid("7df87db6-a346-445f-b688-1adaf9089c7c"),
			new Guid("03b37727-d86f-4b31-b1d1-06e4c1723176")
		},
		{
			new Guid("a46cc49d-7721-4883-93f8-0b4434823bd7"),
			new Guid("d02dfe9c-bad2-4a9e-bd1b-0be6bca3b198")
		},
		{
			new Guid("636a5661-68ae-4692-9c0b-904ad04c2b7a"),
			new Guid("85ffb842-91a9-445d-b9ac-46caada9b6e7")
		},
		{
			new Guid("2d003e06-3661-467a-8da8-5f0bfae04a67"),
			new Guid("8a367061-9297-4e55-a2c0-a5ad7bce3e37")
		},
		{
			new Guid("7645f0f0-3f3c-4b8b-8134-10252c54877b"),
			new Guid("0bc505fe-d6f0-4b28-a257-0168cea07828")
		},
		{
			new Guid("b41c75be-e0b8-4f18-982a-2334d26e9617"),
			new Guid("ef4759d6-c90d-444a-b0fb-bad0c20f8c1a")
		},
		{
			new Guid("13596054-f6ea-4bbf-abca-4707f5b7fbd4"),
			new Guid("59db97d5-9133-4504-b571-8b8cf5cc0961")
		},
		{
			new Guid("aed88281-c41e-4224-9f5c-75efa51f226c"),
			new Guid("c6969fc9-cf55-4192-92f6-095b23209486")
		},
		{
			new Guid("ff812cce-88f4-43c2-a87a-2ebc392f8883"),
			new Guid("711286f7-a0f3-4439-a737-cdb863ad5a1f")
		},
		{
			new Guid("807d1ed5-7439-4a6d-b520-f15beee6b2c4"),
			new Guid("5fe3948c-b5a7-4bf2-bada-d0e35f762884")
		},
		{
			new Guid("b4799952-7cba-4f39-b504-6a8be57154c0"),
			new Guid("af535cc4-e980-4e8d-addd-1279a602c050")
		},
		{
			new Guid("ec08586c-b25f-4112-a004-cd3f9edb5e38"),
			new Guid("ae053a00-8376-43c3-a2cf-cc9fb96e6478")
		},
		{
			new Guid("824fc3d4-5bf9-47e5-badc-8bdd71963798"),
			new Guid("c05876f3-c5a0-4266-b24f-325be94ce0d1")
		},
		{
			new Guid("8583869f-e3c8-46b2-9c5e-190a39b73b11"),
			new Guid("2b17e1ee-6587-4097-acfa-450991ed5000")
		},
		{
			new Guid("cfeeb797-75b5-4f42-9ef2-e96aaf5a3b30"),
			new Guid("1379b0ea-2f21-47cb-84ad-1a8d3b23a988")
		},
		{
			new Guid("8d602d44-d7f9-42c9-a273-d1cf30b087fc"),
			new Guid("63394f61-403d-40fb-b36b-3efe6efab838")
		},
		{
			new Guid("e0e9ab15-db97-4a38-aabc-fdeb5c0b4969"),
			new Guid("516431c1-90bd-4973-8769-11566af848df")
		},
		{
			new Guid("e38da979-18c5-4c92-bbc6-5874a0868e41"),
			new Guid("065623e0-8244-4b6b-ba9f-b811c3bf5b3c")
		},
		{
			new Guid("6c980a14-6561-465a-8d4c-4e196db4ee27"),
			new Guid("1b7360d8-db68-495e-aaeb-5b5be03ecb93")
		},
		{
			new Guid("34987334-2608-4cb6-b7d2-4d785df59515"),
			new Guid("685a94c7-3f45-439f-8db1-c0feabab145c")
		},
		{
			new Guid("07f49cf9-9537-4e26-b14e-272d27469287"),
			new Guid("86d4c3d2-4e63-4225-a2bd-73f09c24927f")
		},
		{
			new Guid("4cf272bd-b182-41ba-a36c-e7bd757e5f67"),
			new Guid("dff5a545-34a6-4ff0-9484-d81de10ce39e")
		},
		{
			new Guid("8f1fbbfa-1c37-43dd-9b19-9c25a6b485ae"),
			new Guid("30d3fdb3-8949-4ed5-a55b-edc06706194e")
		},
		{
			new Guid("a6e5d987-622b-47de-af82-2ffe4e1a5942"),
			new Guid("d942d4cf-a55c-49b3-a794-917f4195e836")
		},
		{
			new Guid("757c9edc-ee60-42c1-92a2-a6a5d64bde0b"),
			new Guid("50d59485-f69b-4e4b-b015-7beaece05bff")
		},
		{
			new Guid("0a9498ff-2bab-430d-8093-1b8752d242bf"),
			new Guid("712c41a3-ea86-4e5b-b6bf-7adf54eef71c")
		},
		{
			new Guid("850d89e7-086f-43eb-b852-94cba76708da"),
			new Guid("795782dd-3d99-458f-b6da-c3a220efb7e0")
		},
		{
			new Guid("3d439681-449a-46ab-9b8f-df66a4c0e7da"),
			new Guid("4bf6526f-4a61-4ec7-90f7-cf2a994fedbc")
		},
		{
			new Guid("cfbe8faa-1b8a-4f43-bbc7-ee3aedbc541f"),
			new Guid("673068dc-1065-474c-80d6-cf2e7b64fad7")
		},
		{
			new Guid("a53ee815-e2d1-4377-bb94-02d97a8bd02b"),
			new Guid("4704f538-d6d1-47bd-b009-c5649320fd98")
		},
		{
			new Guid("1907552a-1024-41a0-ad49-90886decd810"),
			new Guid("ed12cbac-0972-45a2-a429-b2300d67e3a8")
		},
		{
			new Guid("83fbb24b-7351-4356-9b4e-46d4211a61c3"),
			new Guid("a820b365-1763-4d4a-9fae-44325038c021")
		},
		{
			new Guid("675894c5-3063-43b8-8f76-1c88135caea2"),
			new Guid("98a03366-e22d-402b-bd87-3d0ac7456dc4")
		},
		{
			new Guid("d8af2cde-b94a-48f1-93e7-e57dad87f8ce"),
			new Guid("53217522-dd6a-41fa-9e1f-45e5a1a80b68")
		},
		{
			new Guid("e85a601e-0b49-46cf-93a6-fc2652282c33"),
			new Guid("4c2cab91-25e6-46c0-b4c2-75fa4cd2c50f")
		},
		{
			new Guid("6459c897-13de-4c72-88db-a00b11e349dc"),
			new Guid("124482d3-b718-4820-ad8b-2eeaa4d1153e")
		},
		{
			new Guid("6045b1c1-f948-4dd6-be05-aa5695e77c3c"),
			new Guid("2f858a24-e177-4af7-a40c-66b20e501c09")
		},
		{
			new Guid("eff12a85-bc69-46f3-bca3-16dc2ca80b93"),
			new Guid("7ce0faad-563a-4d09-9ccd-a15a33aac5a9")
		},
		{
			new Guid("95dfa2df-a108-451b-a62d-d4ac0858f18b"),
			new Guid("643f0b45-cb5c-42a8-a8c2-9cc06a049816")
		},
		{
			new Guid("7b2634b5-3e4a-4210-a72a-9f33520f1bd2"),
			new Guid("720463da-5537-42c7-9bf2-6442dde1826d")
		},
		{
			new Guid("1118b70f-765c-4e1b-b022-bdd5c672e1de"),
			new Guid("3c649a1a-346d-45e3-9636-4358c7090bac")
		},
		{
			new Guid("838786b2-f79b-45bb-a358-5483a7f9b35d"),
			new Guid("af4739c6-0f00-4715-970d-0d0f0f646960")
		},
		{
			new Guid("01a93518-6c25-44c7-be8a-02350668e983"),
			new Guid("b501260e-a416-4dcf-b182-9ea0bf75ff4c")
		},
		{
			new Guid("50d11825-81d7-42b2-89df-b9c1942cfcd0"),
			new Guid("3c649a1a-346d-45e3-9636-4358c7090bac")
		},
		{
			new Guid("ed817b77-aee3-428e-b4d4-c8aee8c7c972"),
			new Guid("03b37727-d86f-4b31-b1d1-06e4c1723176")
		},
		{
			new Guid("aef941b3-f5d9-4e51-ad3e-f3f088ffbdb1"),
			new Guid("d02dfe9c-bad2-4a9e-bd1b-0be6bca3b198")
		},
		{
			new Guid("2096683f-7386-4a81-8bf9-203fc476e53f"),
			new Guid("85ffb842-91a9-445d-b9ac-46caada9b6e7")
		},
		{
			new Guid("9a015a42-1d01-49c3-9970-fe20b8e4a5f4"),
			new Guid("8a367061-9297-4e55-a2c0-a5ad7bce3e37")
		},
		{
			new Guid("da072eaf-9218-486f-b345-cb0fd2c57ac8"),
			new Guid("0bc505fe-d6f0-4b28-a257-0168cea07828")
		},
		{
			new Guid("45fadcf9-edff-4bbb-91c5-f451e25b7356"),
			new Guid("ef4759d6-c90d-444a-b0fb-bad0c20f8c1a")
		},
		{
			new Guid("73737e78-4d4a-4ff3-b975-1ace2f9d4983"),
			new Guid("59db97d5-9133-4504-b571-8b8cf5cc0961")
		},
		{
			new Guid("1bdd80f2-2d4d-4aaf-9a5e-62fc499201a2"),
			new Guid("c6969fc9-cf55-4192-92f6-095b23209486")
		},
		{
			new Guid("17bcc924-51aa-4d65-85c1-7dbe1737fce3"),
			new Guid("711286f7-a0f3-4439-a737-cdb863ad5a1f")
		},
		{
			new Guid("e013a3c1-cac9-4f41-9147-e272df555dc2"),
			new Guid("5fe3948c-b5a7-4bf2-bada-d0e35f762884")
		},
		{
			new Guid("55515803-063a-4b4c-b0a0-0668d9901552"),
			new Guid("af535cc4-e980-4e8d-addd-1279a602c050")
		},
		{
			new Guid("2943d830-e41f-401a-becf-b452ebbc6c26"),
			new Guid("ae053a00-8376-43c3-a2cf-cc9fb96e6478")
		},
		{
			new Guid("7eaac18a-f50e-41e5-ab8c-b7d16f0f8b48"),
			new Guid("c05876f3-c5a0-4266-b24f-325be94ce0d1")
		},
		{
			new Guid("188289c9-9c4d-46d0-bd18-4e3205a8dcc2"),
			new Guid("2b17e1ee-6587-4097-acfa-450991ed5000")
		},
		{
			new Guid("7c680076-6f73-45d2-b4a8-8acbd73e411a"),
			new Guid("1379b0ea-2f21-47cb-84ad-1a8d3b23a988")
		},
		{
			new Guid("e5bba0f9-2a58-466b-a486-b244f635f973"),
			new Guid("63394f61-403d-40fb-b36b-3efe6efab838")
		},
		{
			new Guid("66235817-037a-40c2-897c-d7abfdf14025"),
			new Guid("516431c1-90bd-4973-8769-11566af848df")
		},
		{
			new Guid("0fd1bc15-2a60-448b-8cd0-c91f6017088f"),
			new Guid("065623e0-8244-4b6b-ba9f-b811c3bf5b3c")
		},
		{
			new Guid("8dee00ac-495c-4435-bc46-81d5142ef10b"),
			new Guid("1b7360d8-db68-495e-aaeb-5b5be03ecb93")
		},
		{
			new Guid("89fcd14b-8488-49ca-9224-c2d89c62bbac"),
			new Guid("685a94c7-3f45-439f-8db1-c0feabab145c")
		}
	};

	public void GetTransformations(List<FormViewItemTransformation> formTransformations)
	{
		for (int i = 0; i < formTransformations.Count; i++)
		{
			FormViewItemTransformation formViewItemTransformation = formTransformations[i];
			if (!transformationGuids.TryGetValue(formViewItemTransformation.Uid, out var value))
			{
				continue;
			}
			FormViewItemTransformation formViewItemTransformation2 = new FormViewItemTransformation();
			formViewItemTransformation2.CopyFrom(formViewItemTransformation);
			foreach (ViewItemTransformation item in formViewItemTransformation.Items)
			{
				if (transformationGuids.TryGetValue(item.Uid, out var value2))
				{
					item.Uid = value2;
				}
				if (item is ViewItemTransformationAdd viewItemTransformationAdd)
				{
					if (viewItemTransformationAdd.AfterItem.HasValue && transformationGuids.TryGetValue(viewItemTransformationAdd.AfterItem.Value, out var value3))
					{
						viewItemTransformationAdd.AfterItem = value3;
					}
					if (viewItemTransformationAdd.BeforeItem.HasValue && transformationGuids.TryGetValue(viewItemTransformationAdd.BeforeItem.Value, out var value4))
					{
						viewItemTransformationAdd.BeforeItem = value4;
					}
				}
				if (item is ViewItemTransformationMove viewItemTransformationMove)
				{
					if (transformationGuids.TryGetValue(viewItemTransformationMove.MoveItemUid, out var value5))
					{
						viewItemTransformationMove.MoveItemUid = value5;
					}
					if (viewItemTransformationMove.AfterItem.HasValue && transformationGuids.TryGetValue(viewItemTransformationMove.AfterItem.Value, out var value6))
					{
						viewItemTransformationMove.AfterItem = value6;
					}
					if (viewItemTransformationMove.BeforeItem.HasValue && transformationGuids.TryGetValue(viewItemTransformationMove.BeforeItem.Value, out var value7))
					{
						viewItemTransformationMove.BeforeItem = value7;
					}
				}
				formViewItemTransformation2.Items.Add(item);
			}
			formViewItemTransformation2.Uid = value;
			formTransformations[i] = formViewItemTransformation2;
		}
	}
}
