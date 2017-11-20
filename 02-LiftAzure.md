# Lift to Azure

In this section we will prepare the services in Azure to run our Bot. If you do not have a Visual Studio Subscription (including credits) register through
(my.visualstudio.com)[https://my.visualstudio.com] for a free Visual Studio Dev Essentials Subscription. When you're finished you're able to claim a free Credit for
Azure Resources.

![Claim Credits for Azure](https://8myiwa.by3302.livefilestore.com/y4mvuFQZ1WWmEYW1BJ1wkki4IdWXmLeVc_kEmvCIDhU1kRz_2ALURgGQlpN4c9lW0BFwVnHogJ8-oUSPZ17x_LReGGsFgvppOz0Cc3pK4sJCY_LeocVggSi1MaVH1rKlJyyDgNjH5gX48SsLTAPrbHpMbJCtekbIZnqxWPCyNyFYIprRZj-fZWJ_X4-7naQ-fHrFjvKFV-jhHgORCPw4QSDig?width=660&height=350&cropmode=none)

## Create a new Resource Group

All related resources for our Bot will be inside a so called "Azure Resource Group". It's a logical unit which summarizes the service of your application.
It also allows you to create ARM-Templates to easily redeploy or automate installation of your service. It's free and provides you some management tasks
to gather Metrics, Lock Resources or Tag them.

To create a new resource group you simply click "Resource groups" from the left menu.

![Azure Resource groups](https://lfezmg.by3302.livefilestore.com/y4m5qMtR9Nxvcr6ayuLWI7z7_asD-H0g1kTsh5PzJC2EBhoJnBzCyRnHs5ZQaPSgrV18gQ7fXcOCvCI563PhUFuazVuGiIYe-a_4auEI4Jo0gAe4_M8fo9RCFvlEd7iruAah4cZEZfxTYKx21QHGNZq9oT0euV9wGRRYR0SLHUPO5pzm3t3oI0jIMDAhDmqcUzZMCm-nE9IPJrdgGl0teQoBA?width=227&height=285&cropmode=none)

Now Azure will open the so called "Resource Groups"-Blade. You will experience, that whenever you "drill-down" into your Resources, new Blades will be stacked to the right of the current blade. This allows you to navigate up and down in your resource hiarchy. To create a new Resource Group simply click the Add Button on the top.

![Add Resource Group](https://ypadea.by3302.livefilestore.com/y4mneOX5sGZpKUJGP3lh7ApRAnUEjhaCjqN9zFVKCmA83UrRS_gTslD0ltgV9aFzmHQQHLpvwhLVdyVnNkNcqwSxgkq6XocoU6BU1JEr_9s8cFrgj7HbjjB0mbuM3j623TA7pQqfCL53bBeULCiWPkzbmClY6TSu4geiA0cBs2xfHjS8gXi3-5vyT5Y8DleUcNBPB0MbH_BWJGQ4CDfFf6I_g?width=660&height=211&cropmode=none)

which will lead you to the following blade:
![Create Resource Group](https://wsqwqa.by3302.livefilestore.com/y4m0Z26z9rG2oMjvuETnRurHcY74f8l7cUmnRKE3L77Y77oq_uWcdRuYCY4E9fN_gDC3N9sQhwBPOxI1bOeB1rsg3XOPobl-LELgQUrS5jWiofL6m0akpa1HnypGjcdGNxFPmIeMy4o9OWoSogD38NPDZqqsoO-6iAGd6RPJLijhQr8WS0aRj0lyTn-IL9DC7ahQjWrasfg8VpeGXyyKb_PDw?width=312&height=236&cropmode=none)

You are free to choose what ever Name you like for your Resource Group. And Subscription should be prefilled with your current active Subscription (which will be billed). **Please choose as Resource Group Location "West Europe"** - for this whole training we will choose as location "West Europe" to address some location specific Problems you will face in the real world.

After you click the "Create"-Button on the bottom of the Blade you should see something familiar to this:
![Resource Group Overview](https://izvhyg.by3302.livefilestore.com/y4m6vJrD-AjPKLyMz1HW7JqEXptgM5eCSwFKUjqd-8KnH1DFbJIQWnJKdFSWnwPrYyJqXAqV_MybM1HOi7F5IGlQp0Gg207IZn_D2OFh6V2MW4B_-Ng-1S63X9OsraXkM-9hRyJ3S5pG0ciV__4Q-mV7ROALiReBswA2HL8L1odRNFQxpdNghTn-NZ9A6qAKf8c7x5PKZ4kc72PmQOH5EJqAw?width=256&height=197&cropmode=none)

Now you have created your first Azure Resource Group - congratz. Let's move on to create our first and most important service. The "Bot Service".

## Create a Bot Service

While still in the Resource Group Blade, click on the "Add"-Button. This will lead us to the Azure Marketplace, where we will be able to create/purchase new Services. Keep in mind, we had been in the Kontext of the Resource Group, while moving to the Azure Marketplace. New Services will be added into the just created Resource Group.
![Add Service](https://lfe0mg.by3302.livefilestore.com/y4mtoZMToCLh5oUs-Rikf5OHmjOAU9fChAC8G00MAdfG3DPvVUwwAszQfdxXd8tcvKv52xcxkRZwsV-0H0ia1u-0Tlvj-tzcvyHUXZ345Lt03SXjixNidugQPa68SVqqOOkhECcbInqfdTxdflVNITkAYRfGRbL7mxWF3swupyKPff85i7WwTZRcbg8bsNDVpyNo4fovFogJlo2z3eR4nvbeA?width=481&height=306&cropmode=none)

After you clicked the "Add"-Button a search will appear. To quickly find the right Service, just enter "Bot Service" into the search field and you should see something like this:
![Bot Serivce](https://jrbubq.by3302.livefilestore.com/y4mFa7S92HEJRYPUazInlDLJdOT27-Oakvwh5kMHOv1n4-auq3vFMkkSgTelJF4DYahuln9DloK3w6_HYIUi-Za6BdwhoXk_AuHEHXbcD2MxBwQJGK3EChK7yC9KhvFwFXjWGOUvZosn4tSQ2TJTnUl-ZVqENUvbQUlaISu7D5vKG0lz1Eg5G3fzJdEniwuO6c6J56_wMzG_xfD2vXUE4Ovew?width=660&height=218&cropmode=none)

Click on the "Bot Service (preview)"-Entry in the list and you will get the Creation Blade again. Only this time, you will need to provide different Inputs.
![Create Bot Service](https://xjm9sg.by3302.livefilestore.com/y4mErg2rs0q_8jiDmpoPc_Oz0nib1pkzl1sIdgqlaTMGLf-JaoVlZOvgmcYQv0I7yxGitmfXz3Py5m_V2qQh9bvwov4j4-G4Z1l7EjTiyaUCGFYlW-yohnzFxXfW2rj1Peqw8gScgyuJlWEyryLHGGpF8jEkBtLDChdniH5P5t4b5Qg5praX_BtZEUDRpU0eonmobZ6c0YMQ3vEuoyBMMUBsw?width=317&height=515&cropmode=none)

Let me go a bit more into detail about those values this time. First of all the "App name" - which needs to be a unique sub-domain for .azurewebsites.net.
This means every website hosted in an Azure App Services needs its own unique name. Also that our "Bot Service" is "Website" as well. Based on the simple Fact, that our Bot Service consists of an Web API Controller extended by a Framework called the Microsoft Bot Framework. The Framework allows handling of special Message Formats and supports several Channels which allows you to attach your Bot to Facebook, Slack, Skype, etc. very easily.

Since we initiated the creating of our Bot Service from our freshly created Resource Group - this Blade should be already pre-filled by it.

But the last two values are the most Important. Hosting Plan consits (at time of training creation) of two values:

- Consumption Plan

Running the Bot Service inside a consumption Plan indicates, that you want to run the Bot inside a so called "serverless Code Environment". Technically it only means you run your code as an Azure Function which is like an abstraction of the Machine behind it. You do not care if it may be a Linux, Windows or completly different System. You just want to execute your code and will be charged by how often and how long your code is executed. The more your Bot calls your Web Api Controller - the more you pay.

- App Service Plan

On the other Hand you have the traditional approach, to run your code inside an App Service Plan. In context of Azure this is a new Resource and can be imagined as representation of a virtual Machine running in Azure providing all applications assigned to the App Service Plan. But since the virtual Machine is running 24/7 you pay for the service even if its not used. It might be a bit more cheaper overall - but this is strongly dependand on the size of the Machine.

Last but not least - **choose the Region West Europe**. Otherwise some steps will not apply to you and you might not be able to follow this Training.
After you did so, press Create and wait some seconds until the Notifications tell you, your service had been created. Navigate to your newly created Bot Service and you will find yourself in the next Part - setting up the Bot Service.

## Setting up the Bot Service

After you navigated to your new Service you will find the following:
![Create Bot Service Kind](https://ygtb1q.by3302.livefilestore.com/y4myJkOpDW1eatu4DrcqZbUYRRXL1oyyugnMC1grsDtJFC1ZQrwtYdKqDhkMuMLF8CwwrjKESKRMYpwCr5MZ-T50wCVZaru4FHThizcJ5OnOXdoHNtZRZxElrJvyiyqLQY_8l0VoXC6ZDd__zvEdd8g-jtwf3Wd2fymgeuwuJ3AA8ODKaMb8-bnO3m3RW6De-IKX0uWrXaCz46apinnXyzOwg?width=660&height=493&cropmode=none)

we go for **Basic** for learning purposes as well as for reasons to reduce Problems you may experience. Especially for those Service Kinds, where external Services are included I experienced and chaning and troublesome behaviour every time I used it. But no worries - we will still use those services and learn what the Wizard would provide as an template.
