# LUIS (Language Understanding Intelligent Service)

In this section we will have some hands on experience with LUIS. 

The documentation explains LUIS with these words: Language Understanding Intelligent Service (LUIS) allows your application to understand what a person wants in their own words. LUIS uses machine learning to allow developers to build applications that can receive user input in natural language and extract meaning from it. A client application that converses with the user can pass user input to a LUIS app and receive relevant, detailed information back."

Please find the Documentation to LUIS in the link below;
https://docs.microsoft.com/en-us/azure/cognitive-services/LUIS/Home


## Create a new LUIS APP

Please move on to the website below to start creating a LUIS App. LUIS has a EU website for the European Region so please make sure that you are on the **eu** page and not the **www** page.

https://eu.luis.ai/home

From the main page click the "Sign In" button on the right top of the page. You can use your Avanade credentials to sign in to the LUIS app. After you login you will be forwarded to the **My Apps** page. If not please selecet the **My Apps** from the top menu. Now we will be creating a new app so please click **New App**

![Create New LUIS App](https://jrbvbq.by3302.livefilestore.com/y4m9tVOQDoeHsI4Pc_K5wP99l32wooHTzLHDZi52z-52moRn1xfbaAAHjQt7g1beZB3ieB50Tm1Wv_mFBCz5SAZtkyv8ID6QSBAtz9KJ1MrCKfHwgf8hAus1xhRiSEDdcl07kEDQg4FGNMTlpb0zAL9CLj8FogIqjw8qZA5gLytDc1AWnkVFpvGt0xndIDSqFn1Ze9zj7YC9yK24610nwSN-w?width=468&height=198&cropmode=none)

In the page that pops up enter the Name, Culture and Description(optional) details for your new LUIS app. Lastly click the **Create** button.

![Tap Create Button](https://izviyg.by3302.livefilestore.com/y4mtZu56sV8WJfyuGgSSlzecDNNsef9x3WjATSx_dhRThxdWCfANyv1mW6TScoPmFbEQpfTjAApUHcRCIED19fIXbrNZi_PW_IuouRkGqycGIPFq6Bvx8wh8fwmmM_cgo1jVPEYYoXUc7zz26rT4m8ymt72x5m9autVED-9HP91LrEawRVegeOMg0a2h8OEfXXEKhV0OKB_mPQN1zE_t1T_FA?width=600&height=414&cropmode=none)


## Get to know your LUIS APP

In the Image below you can find the Menu that should be visible on the left side of your screen once you create your LUIS App. You will be using this menu often while you are setting up and using your LUIS App.

![LUIS Left Menu](https://8mygwa.by3302.livefilestore.com/y4mYIrgwfF8c-Nv-Wk7HGQ4rCPUBVy1SRixEs0GZvE3YLMY2fAM0W4LF-VbixxFHcw2xONc3FlWDShWJTAGDmwrd5xeEgk0zRjC_ZwQ8AoQifQos3oTJbj_CYLeVqjBQOgtibhyPbz6dlSD17NUUi8CYM_AndZoCgpDT6ATXWy0XqXLhokl0uzpuKs7qdEIJGtWi8P2zcMdhYvN3DlyjLuMdA?width=515&height=1137&cropmode=none)

**Dashboard** -> Facts & statistics about the app's data and the received endpoint hits at any period of time.

**Intents** -> A listing of intents in the application.

**Entities** -> Manage a list of entities in your application and track and control their instances within utterances.

**Prebuilt domains** -> Prebuilt domains are off-the-shelf collections of intents and entities that you can directly add and use in your application.

**Features** -> Use these advanced features to improve performance and avoid mistakes in identifying and interpreting utterances.

**Train & Test** -> Use this tool to test the current and published versions of your application, to check if you are progressing on the right track.

**Publish App** -> Use this section to Publish your LUIS app.


## Add Intents

Lets go to our LUIS App page and select **Intents** from the left menu. An Intent represents actions that the user wants to perform. Our aim is to add two Intents to our App (*Giving Feedback* and *Providing Idea*).

After selecting the **Intents** option from the left manu, click **Add Intent**. On this pop up we will be naming our intent and then we will select **Save**. 

![Add Intent](https://ypabea.by3302.livefilestore.com/y4mWQpIGtsvqy3P6Pr22p05FHYNvjLDHkEFfo0znPvbFjlDhn276t6J0dyeDEk3aXiuRO5kdCrzfpvVaVfUbC7BvFSQcMzqV7iYw5jjLN7G_WmLv51lB0mIR7cPph60_LI-FynG_KuUWsYEhCLSe_LXPllAYMJQzC73gszNLn7RQOgnafZJKZtIviFH0nOEIhhov8HmKdMMZGPCzoo4mS3gQg?width=1321&height=475&cropmode=none)

After saving the intent we will be forwarded to the newly created Intents page. Here we need to add **Utterances**. You can also reach this page by clicking the Intent name after selecting **Intents** from the left menu.

**Utterances** -> This is input from the user that your app needs to interpret.

Filling in the Utterances are actually kind of guessing what the user might type in to reach the specific intent. Before we add the Utterances we first need to add Entitys. We will be coming back to this page after creating Entities. 


## Add Entitys

Lets go to our LUIS App page and select **Entities** from the left menu. In the previous section we added and Intent named *GiveIdea*. We know that the user will give an Idea so this means that we can create a Entity named Idea so that we can use this entity in our Intents section. Once we are on the Entity page we can select **Add custom entity**. Enter a name (Idea) and entity type (Simple) then click **Save**.

![Add Entity](https://ygta1q.by3302.livefilestore.com/y4mFeluRv9eZI5jcefTzEAruzxP3i7UzwgvUnoMg3LIsmfwxDZaINw7LVA94bDQQCLGazdlGvEy9eXNufQs8qu5YamQw-yI3XRzyaAsVIGFesSfoyXCkm3T4a-La4vHkPwCi8bgfnnJlPZF-nEfBbFtXKvyGpk35b1a1CKYDy-m0TlW7l5Zze6VG6-Ya3h6xD9vtZfqziuokK55KaVgZ9nOBA?width=1212&height=643&cropmode=none)


## Add Utterances

Lets go to our LUIS App page and select **Intents** from the left menu. Now click the intent that you previously created so that we can add utterances to it.

In the box that says *Type a new utterance & press Enter*, we can enter a new utterance. 

For example lets enter *I have an idea* and then press enter. Now you will see that this utterance has been added to the list.

For example lets enter *why dont we have more holiday* and then press enter. You will also see this in the list below. As you can see the part after *why dont* is an idea. So we can basically assign the words that come after the *why dont* to the **Idea** entity. We do this by clicking the first and last letter of the part of the sentence that we want to connect to the Entity. Once you have this part in the brackets there will be a hover menu asking you which Entity you want to select. From this hover menu lets select the **Idea** entity.

Don't forget to click the **Save** button after creating the utterances.

 ![Add Utterances](https://ypdqdw.by3302.livefilestore.com/y4m2Y8E-SebezzcGNT19LlUaso38mpVguSVkzsw0Uda-iMoV2uxiD5fdtQ5kqLBCJNQNF_KP_pRupglhxCgpBww11mvOIpXY0ui8DsykL80TjvueZPAevmEa0yV6EYU8f6HnOVT-hOzDRwJtHxteMiKvWWvEAGHqXFE4WHMm2KKGP5slvedtc9zkOjaDXBtssmURpfuvey67qPS1C2FB1-1nQ?width=1808&height=1168&cropmode=none)


## Train & Test

Once we have our Intents, Entities and Utterances it means that we are ready to **Train & Test** our LUIS App. We start this step by clicking the **Train & Test** header on the left. You should have a similar page to the image below. Now you can click **Train** or **Train Application** button.

 ![Train Luis App Main screen](https://ijvlyg.by3302.livefilestore.com/y4mJUieTXh154JDbCGJH4tQnBuWowX7YwNlb6NWCE09YmtSyuoNHvH1_BUPrnekz5o-jZsf9SVH9Y8luyPNT1GUfSWHeUbaeeW7Br-_RI56smmUXWjfCpOCwmxJgrW0Erwg2LAVTad3GACN7Wx58fTS0uNzuo6Q50zqypP-Y8KWLPpvpIP6TzLF6oYkBLemP7OCnOS55cLTxoU2yui7NH9KJA?width=1211&height=502&cropmode=none)

Whenever you make updates in your current model, you’ll need to train your app before testing and publishing it. When you 'train' a model, LUIS generalizes from the examples you have labeled, and develops code to recognize relevant intents and entities in the future, thus improving its classification accuracy.

On the current page you are able to write sentences and send them to see if LUIS understands what you are talking about and also if it can capture your Entities. 

Before you start testing, click **Train Application** to train the current model on the latest updates. Note that you'll not be able to train your app until you add utterances for all your intents.

In the scenario below LUIS understood that both sentences are about the **GiveIdea** Intent. The problem is that LUIS caught the *$Idea* in one sentence but it couldnt catch it on the second sentence. So this means I have to go back to the **Utterances** page to improve my logic.


 ![Train Luis App training screen](https://78yjwa.by3302.livefilestore.com/y4mOqqlzVil40NLYagA7gK_62OI1IFPjgv5gF1dolscQPs7dIB8pMJO3dMuEXkCB1EZSxX1RP-rE2YlnAW6dNBX_-04a1LAu5-rfDCl12CEguOIZW2pHORcn7C7Ll0xomFqHAQfRIsKpifVgZw_XyAd48APTCBMELVA53Zer-j63nP-gWMtgYiT3tg0rmXdWtYLfS41bNdMsBw41Vws-0Yq7Q?width=1210&height=640&cropmode=none)


## Create Azure Service

Now let's login to Microsoft Azure with our Avanade credentials.

https://portal.azure.com

Please open the **Resource Group** that we created in the previous steps. Click the **+Add** button so that we can add a new service to our **Resource Group**. You can find this button in the image below.

 ![Click the Add Service button](https://x2tg1q.by3302.livefilestore.com/y4m9V_rC2tH8sxzBtktt_0dEKFauavPLTN65IJBBXuWuiBnayeaPSvddk21zRe8rEQsjyKamcMxycbyP0abpRUml3f5C2gDP0KjqHuhs9kLIyk9zKnuNNXx16SZKvOBEWrHGwPe1NEB2nh2toKTNHbjzuvfeIfM8IfHnKth2O-CyT5jlQDOzMD1UZtQaw07Kbhyh53Kt1N5gPnebqkmAAz5YA?width=761&height=217&cropmode=none)

 In the search bar lets type in **LUIS** so that we can find the **LUIS** service. When you find the correct service as shown in the image below, click on it so that you have new blade with the description of the **LUIS** service. Let's click the **Create** button on the bottom of the new blade so that we can set up our new **LUIS** service. 

 ![Type LUIS to search bar](https://lpe4mg.by3302.livefilestore.com/y4mAnvba5RY3ftwEl9uSmX3JgDIn_aevio-UxIE3660qfWjFkdW2z-uz7MUT4IQFUiI2-IblCnBzXFRiFEU4zYIqr32s2IultPV58jpEePbPbOi7MEzuOJlwW30NxW4B3GSe4x67-k0Uwy1m_iNwwAAD2fp5b95cV5vPmxSVxy0ivhNYugcNcya4ZcsuHP0Pdp6wjfhJizkrmtJZaWPFCbFQQ?width=775&height=297&cropmode=none)

In the new blade you will see empty fields similar to the image below.

**Name:** Enter a unique name for your LUIS Service.

**Subscription:** Select the correct subscription.

**Location:** Select West Europe. This is the closest service location to our current location.

**Pricing tier:** Select the F0 option. This is the free version and it is more then enough for our current event.

**Resource group:** Select the *Use existing* box and select the correct Resource Group from the drop-down.

Lastly, click the confirmation button and then click **Create** so that we can create our new LUIS Service.

  ![New LUIS Service details](https://kyirka.by3302.livefilestore.com/y4mqiBQBnaR5aKGAl_UO5z3hDotQPAlertbS4eJa25vXoBZVF7GZd_TAdv_QuIKlPJQLwox6gLfRyL5LzrzC9yKLzFFUmsp_eQhS_UaG6_3TZ0PDcD1jWq5Gn4HPZTz0DpKo0pzOL8HMxnOJL2GK8hpGdb8YAiBV1gTVQh7JAuGo_ITYwbCSy5ymmoz56_rdVhmlQzrosFRy82-crlWWOIjHQ?width=288&height=561&cropmode=none)


## Bind Azure Key to LUIS AI Model

Now its time to bind our Azure Service to our LUIS App. 

Select **Publish App** from the main left menu of your LUIS App. You should have screen similar to the image below.

Now please select the **Europe Regions** and then click the **Add Key** button.

  ![Select Europe and click Add Key](https://9g1q7q.by3302.livefilestore.com/y4mQc9O_dp4DiGRMT4uxVYqpr8IkmMeLlRDRlwpUGDo5Km5AVC7Sercr29KPFXbdxhsY8YHgw40qsxxqfQ5XGLhO3XGOL45HdDv5mR5wd78chwY1sjQG8EOeCpLAo9qUbcluhbfIlbUFKDsBIIcCE6wz_o6pCTFcqzAkSRjocPR7k1_CnGAFpB8n947i18bMd-fqE5KULwySZQvRl2uzNyDXg?width=932&height=550&cropmode=none)

From the screen that pops up you will see a similar screen to the image below. You need to enter a Tenant name, Subscription Name and a Key. Things might get tricky here so continue reading the next part.

 ![Assign a key to your app](https://w5ncsg.by3302.livefilestore.com/y4mEWHDi4_8ftzgCCSYQpavqNiZbt8ANBytrL0yNHQ7mcMygN5YU4uQoDeXT2pbRXIRFPrxAyFGyvmMqxsqg6XoUbOVtqtCkCf1zhZNr2KbIemCh0a0AZ2WNmx4Tv81kd8BSMiW_9dQWv_fzbfEdvN6ZjXqWqFIAaipq9w8z3Q-EbbE9tLRL2eruSzZACnrlab51UnZ8knx1a7YGMPBVHx63w?width=607&height=431&cropmode=none)

###### Tenant name

You might have several Tenant names in the drop-down or maybe only even one. Let's check if what our correct Tenant name is.

We go to Microsoft Azure. On the right top of the page you will see your email address and your current Directory. Make sure you are on the correct Directory. Now mouse over your email and you will see a hover screen similar to the image below. 

Your Tenant name is the string next to your Directory name.

 ![Tenant Name](https://wcqbqa.by3302.livefilestore.com/y4mZm-pl7kCSTDk4P9ApDSdYrLJkqvexl_pWR8kaWTDLx-eRLu_7gS7lArNrSrmlJ0WrEUiV9o8YxI0EZzj6QRXgRXGh9yvAHZhJ8S49KiWUQfjIiEff-VRqOUcnOO63oj5ZuQu7WE3T06LCf-nO8eKH2LVz-HW3MdNSnqNHF-uvWfptxMtQjBpgrfbJN_t4zIKRyQjAFPnSBgWkEUmZkg7Gw?width=1071&height=283&cropmode=none)

###### Subscription Name

Make sure you select the correct Subscription name.

###### Key

The Key in the drop-down should be the same name as your LUIS Service which you created on Microsoft Azure. 

If we are all set you can click the **Add Key** button.

Once the steps above are completed you should see your new key is added on the **Publish App** page. Your screen should look similar to the one image below.

 ![New Key Added](https://jbbzbq.by3302.livefilestore.com/y4mtcro2KmONlLxyJzHOP8fw7sUxqfKl7vQwHFoEwm7f1e_oOZQpCHUfgZqh9onvPNgs6C5GiLiCle_shsKECo7oVNTr43H07kvuzP0oRuQ8q4vM9MyuPtX7LYndfseFgeNNzDAv0_ZdTLWwGaD-XTOsSydGWI0AyOnOW-2nfsUHUXMA-Wc_DIE2XOgYw-e6ks2AUUMkbycxiJNwHluXDMwFw?width=1353&height=262&cropmode=none)


## Publish your LUIS App

Select **Publish App** from the main left menu of your LUIS App. Make sure you added the new Key as explained in the previous section. You should have screen similar to the image below.

  ![Click Publish to production slot](https://9g1q7q.by3302.livefilestore.com/y4mQc9O_dp4DiGRMT4uxVYqpr8IkmMeLlRDRlwpUGDo5Km5AVC7Sercr29KPFXbdxhsY8YHgw40qsxxqfQ5XGLhO3XGOL45HdDv5mR5wd78chwY1sjQG8EOeCpLAo9qUbcluhbfIlbUFKDsBIIcCE6wz_o6pCTFcqzAkSRjocPR7k1_CnGAFpB8n947i18bMd-fqE5KULwySZQvRl2uzNyDXg?width=932&height=550&cropmode=none)

Now please click the **Publish to production slot**. If the publish is successful you should see a similer view to the image below on the top of your screen.

  ![Publish Information](https://ijvmyg.by3302.livefilestore.com/y4mjfqhoEjZqf19zgR7dFbSTVCNRU8qpCg4SsLjrU2Cvt-M5O0-h8QuS0v-y746ocYgSjIX4NqmOJT3lkk0OLYFQYfnvSL5aXEu6BqIAOxESO-aQvdFeiCPKKalWrO9j7KQ9i7vM8zpSfUlPJhZi9wdkBkO5YyiqMnXdaK_WMrf7G1vn1OMkPyz6qsagdsxTXnqYoLqZ9oLnTWBu1c_JRdNXQ?width=431&height=115&cropmode=none)


  ## Add Keys to Microsoft Azure Web App

Now it's time to add our keys to our Microsoft Azure Web App. We always have the chance to save the keys to VS but for security reasons its always better to save the keys to the Microsoft Azure Web App and then give a reference to the Microsoft Azure Web App from VS. You should find two keys: **App ID** and **Key 1**

To find your **App ID** open your LUIS service on the the Dashboard page you should find your **App ID** string.

To find your **Key 1** open your Microsoft Azure LUIS Service and click the **Keys** header from the side bar. In the page that opens you should find **Key 1**.

You should add these numbers to your Microsoft Azure Web App. Open the Microsoft Azure Web App you created in the previous steps. In the left menu bar find **Application Settings** under the **Settings** part. The left menu should be similar to the image below.

   ![Web App Application Settings](https://w5mqsg.by3302.livefilestore.com/y4m5NbT5UBfeDVbsJwQ6P5zwq6jGuBmZz2rDnKjgAyTmj0ZoxX045SKrPtwA1M9C_rZmjXf4fqILiWOJQvgj-3VZ96Fb1bLpcw6W0CANfOEPrsz8waeCQo6pQ5DH1A1dkunrpPCinQul9EEaVHToyUal-CtNOxroi2Uy230qO8oaeyRewqJbu2MziyKMdP2gUIj3nw5aRHz57j_mtv38BHZCQ?width=193&height=266&cropmode=none)

Now we will add the two keys to the **App settings** section. In the **App settings** section each line is formed of **Key** and **Value**. 

The **Key** is kind of like a mask to the string you will save. So you will use this **Key** in VS. By this way if someone gets their hands on your script they will not be able to reach your keys.

The **Value** is the real key value that you will be masking.

Please check the image below. You should add your **App ID** and **Key 1** strings to the **App settings** section.

Don't forget to click the **Save** button two save your changes.

  ![Add Keys to Application Settings](https://wcqyqa.by3302.livefilestore.com/y4mIZBEFB4fEjuJ933k1ZU6fnvkR5-QlS1F6n2LeJwkcQa-WjK7xICZbIxSbk0G4_88oQ_U469vAPANdYjyjfAIWkhCJk-LCRC0nWHitX6SCO7EKrGCYFL2-tomKuZlSUQfPfkz4fZ4UVKnyGXaiLmAMiAh4Az-SkPT_QYCEFAicvjrNWkpnLmKimYJ2LhIrsgUDk0P1dt1crVmgBpBM-DQEw?width=1032&height=151&cropmode=none)

Once you save the two keys to your Microsoft Azure Web App, its time to add the keys to your VS project. In VS Make sure you are using the **Key** names in the image above. You should add your keys as shown in the image below.

 ![LUIS Key reference](https://jbbwbq.by3302.livefilestore.com/y4mm_TaqolAOGPIwSRLCiYFBiEK72t4C0nUHlbcRP8Pf_tGHd1UM33JBfT6XngZrDXxXwl8zL65c7bTLhEt-OioLkmKyw201Jb0-Hsmt8O1TIwQ6hzlOH-PLl7tHGZg-fSaYDm2a_0NJbwAv9m7cuT_8XqJjRfxHH3xdarrN9hIuCquttrylsJrpqepNpyGRhZFpjcS0-IWkf5DsBG45nnn7g?width=1110&height=92&cropmode=none)