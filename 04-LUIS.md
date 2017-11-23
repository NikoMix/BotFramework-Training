# LUIS (Language Understanding Intellignet Service)

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


## Create Azure Service

## Add Key 

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

For example lets enter *why dont we have more holiday* and then press enter. You will also see this in the list below. As you can see the part after *why dont* is an idea. So we can basically assign the words that come after the *why dont* to the **Idea** entity. We do this by clicking the first and last letter of the part of the sentect that we want to connect to the Entity. Once you have this part in the brackets there will be a hover menu asking you which Entity you want to select. From this hover menu lets select the **Idea** entity.

Dont forget to click the **Save** button after creating the utterances.

 ![Add Utterances](https://ypdqdw.by3302.livefilestore.com/y4m2Y8E-SebezzcGNT19LlUaso38mpVguSVkzsw0Uda-iMoV2uxiD5fdtQ5kqLBCJNQNF_KP_pRupglhxCgpBww11mvOIpXY0ui8DsykL80TjvueZPAevmEa0yV6EYU8f6HnOVT-hOzDRwJtHxteMiKvWWvEAGHqXFE4WHMm2KKGP5slvedtc9zkOjaDXBtssmURpfuvey67qPS1C2FB1-1nQ?width=1808&height=1168&cropmode=none)

## Train & Test

## Bind Azure Key to LUIS AI Model
