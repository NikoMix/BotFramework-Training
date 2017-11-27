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

On the other Hand you have the traditional approach, to run your code inside an App Service Plan. In context of Azure this is a new Resource and can be imagined as representation of a virtual Machine running in Azure providing all applications assigned to the App Service Plan. But since the virtual Machine is running 24/7 you pay for the service even if its not used. It might be a bit more cheaper overall - but this is strongly dependend on the size of the Machine.

Last but not least - **choose the Region West Europe**. Otherwise some steps will not apply to you and you might not be able to follow this Training.
After you did so, press Create and wait some seconds until the Notifications tell you, your service had been created. Navigate to your newly created Bot Service and you will find yourself in the next Part - setting up the Bot Service.

## Setting up the Bot Service

After you navigated to your new Service you will find the following:
![Create Bot Service Kind](https://ygtb1q.by3302.livefilestore.com/y4myJkOpDW1eatu4DrcqZbUYRRXL1oyyugnMC1grsDtJFC1ZQrwtYdKqDhkMuMLF8CwwrjKESKRMYpwCr5MZ-T50wCVZaru4FHThizcJ5OnOXdoHNtZRZxElrJvyiyqLQY_8l0VoXC6ZDd__zvEdd8g-jtwf3Wd2fymgeuwuJ3AA8ODKaMb8-bnO3m3RW6De-IKX0uWrXaCz46apinnXyzOwg?width=660&height=493&cropmode=none)

we go for **Basic** for learning purposes as well as for reasons to reduce Problems you may experience. Especially for those Service Kinds, where external Services are included I experienced and chaning and troublesome behaviour every time I used it. But no worries - we will still use those services and learn what the Wizard would provide as an template.

![Generate Credentials](https://jrbtbq.by3302.livefilestore.com/y4mK_AaVZyrfGsaafoyPa14Rd6uj5-IHL5kNany3OdTTFfm4koYeedMONstsWGduM81DPWSlIZmrXPye148eD-X5P4So8rO0rlsUjkRQk1A-A4l9JakgfRJHVnHZZrcZ0cdJR481slVIQAh7QwqRAEKUX3MY34oA71CaBEO9oVtnOlTzg1nOhIOWWZt-u4i_XKKmkd2maa0OvohiHj6Gkn-uw?width=660&height=399&cropmode=none)

![Login](https://izvgyg.by3302.livefilestore.com/y4mCvWJ3dxsEKZLO2nE0l9xVJ576TFUe_SvzHySLWfqmzYC1UzJ09omg3yUvcZ1tsmcj5weOzsrhZ-ucE8sYtf3Kj7Oz1BvXH4C7supZx3qhheAnEo911l_n_ZdODC06ohYVaeq4rr2WdTcMfhCiIeyBqWtZkzb_jICLh5VVDfJbRcdL44fah4WSZQQevFCYm5ivx-3kprHNkfsyf7hvub2mA?width=229&height=256&cropmode=none)

![Create Password](https://ypdpdw.by3302.livefilestore.com/y4mSbgnbJb5QLrNVJf8cCSld-LhJpEm4cCKS4HbvOHVQIPrtV0jroSy2E_B9ZZ1BTK3WFCyJe9liq_LiMZbozjLPWzuHE8hBVvy1nFy1A7nfxzOpLQJU8FbYkw2euqCc3tNPl8jXK9z4Vv7j6u6aCh5nHY8EGRqksPwcKpJAGqEDLgRHEsWr_VoX32QPtRM0LqSWvDSnGNcNu5RqSQm0X9WUw?width=256&height=125&cropmode=none)

![Generate Keypass](https://lfevmg.by3302.livefilestore.com/y4m9hqRmKWQAhYMTyRVY3_BDIUDrMAIntaIho3XoLRsOGASaiPSaO-FV_yZ6wqIIzLIVOt0v_jZJP5QTvAEcAJXTlMIgoiBtKWZA7xXp7OK1QYrwCn95N0NgPCivLP3gmZA8ex3hdijDeAxivYjBAVugjanZ3j3JG5VAGUQqXvM9QQkKPcSBW4Kkj53scr6DGes_Y2Mes8KCkTBYB5KMZ4H-g?width=660&height=341&cropmode=none)

![Fill Credentials](https://koiika.by3302.livefilestore.com/y4mEvIwjsrnZAx4ojM99Hgq5wZmK3B4yF2DIx0X44vpVwd-wgZ_-xjHVt9oQU4nQCu57dbeYBzAuafAHNloeSE6JYPokndBwPs56kpFWZrqlp-TNu12AFT_AMidU42uzjWsycDqXq0xdogCYjsQRMp_iO5rKpd1B_mOArHgXZpEXTGnxCe2CqJR__b1cuCjIT0OX-YnmMKgZ3NKJd-iv33gsA?width=256&height=150&cropmode=none)

![CompleteResource](https://ygtx1q.by3302.livefilestore.com/y4mt7FYtdBOOLPqqY8n3I-iy0jPAaK0eXJzrkOiftVglQxWmWdeB1jEFeVRO0_MGHyDmWcls7MEAH2N6CdR81q-fO-h75K0-rut-H5YPgdWwLQ915iuraRODz8E0Y_jznmKSMS_7jVkc9wxpXgpxcj2qKZerewu6Vnuctfdrf3x2KBm9OeOtMEbz9DWG5UmvLbUmWdkJ1XJ9gN8pZbms77mFw?width=256&height=188&cropmode=none)

![FinishedResource](https://xjm5sg.by3302.livefilestore.com/y4m1YU7j5uYT0rloKTwhevVDNzzy6ndYNxNtUpo8HqkVJk8hK6QCMEKkr0Y_yqTfppRnt81BXDthTVx3u-YjzFueKvJScyM6zduO5D4cD4ohlvzP9Nh2CrOwOBJuA0y29t0foJSh1Llj03N3jULnj84B4VDL2EUdAAEY-HT246ltWAU4ZK6FeY3hO0X7VcKEyA3mR33Mud5BDPu50NOQP7P8Q?width=660&height=482&cropmode=none)

![Extend Deployment](https://wsqsqa.by3302.livefilestore.com/y4m9FUqZVM05oos5DPH3Zc2m6rgX4ByozInyaPNHDgAyDjt0zJtQjX5XstSoWnm64JQGVutvocEuTQTWfBCSkoQun4EAdcR55lFuX3LhaYIOA8cZPAfZOmdzp3Oh2qui5zQlq38IrkmaROEGX09iCyk5jpM1Kbjs7ZNP3_CBGc2RURdjHnrw929Xa31VLLXRV6gwtgbJuRjnELmBpD2Ygb5kA?width=256&height=138&cropmode=none)

![Configure CD](https://9w1h7q.by3302.livefilestore.com/y4mWwUqdlaelHuS_LKL_qfFAxPiZIbbFtQ3AADOufGs707OtjHZRY8YMWtjUMWxkzXLltNidayUrqeci2luGXXmxWPofxkx013GI57VhhY4LvK4tN_ZRiQmLpdQmzgkq-hYdNV23AxBaN_1j6f0WcUlPEfqsElA5yTY8RvgWq2TpZJz4QNE9qoSYTpBtaM-in5D1uIUv7XNEeVwggDWu0P_WQ?width=660&height=483&cropmode=none)

![Setup CD](https://izvdyg.by3302.livefilestore.com/y4mYNVemRmQAjreI0A58AdgNKhwCkALOkShscZ7V0UDwRT5OErY-FRsosow3xZUXi1aCMzd4P_dsIthxOe9Ip5Su-hjfZhpb_lJvxyTekOWOZ9wYCr2rnZbuhW7l9P68ysr7CnXtAfJFzYqq5Xe2ocGdFcElWUc07Szrd8Gvyt7WnVGUBJkXUCQNy8jPffkJKSQ1MSU8ezSqApW7WezWAbxuw?width=256&height=88&cropmode=none)

![Choose Source](https://9w1k7q.by3302.livefilestore.com/y4m2st_r8k_opUbcHgkoMwvPZN_F9A2lbYoJaPp7weLQo1YB8RYC9lDayrDfhdHimRx-Ws9E6M1vIWCYnq4Ho41jztWO_Lo8o7YJv9YdwSL2ucrZDaHYThM62ZMOlo_cw_J7Ksov2nJE0KAaDIs28ive-7h5i-LS49f3J1i-T2sPuwXr0myosfB6oWYbfbmm1KBbZ7ScPEhZIFXfZ2ZknBvHQ?width=256&height=126&cropmode=none)

![GitHub Source](https://koilka.by3302.livefilestore.com/y4mJCxp81jz5blMiL6IbYTPT90lVHJC9T3zwpBdiGocL44ctIij6fkKUXYRmy5oiVkRSgGFfrW7DGGfu33K7zUSqsB6tNo9_xyIZuv2JUpy-rzQMyOAUER-j_xOBdjZfjDq2JKENDIkuVOESqxIBG4ErK_zsRn8Fl2MxhyKv24wZEXI22eoEgHBdRBhGEc538FQojP840dYxN8ihdBckVpS-w?width=181&height=256&cropmode=none)

![Deploy Options](https://lfeymg.by3302.livefilestore.com/y4mTw5UTNCs_1DfxM48Ml6lHszazw1FhDuUtDrhnbeCjJQiZ8zuY7CxXhaxKXzU5l_uB7k40XKezWKUT33lNUFHb3_sfaqY3ni5sd3HwlAN4umWK5hExDo4U4NULZgGYpqbiW2kRRvB8An12mcRWl_azSlKCkw_U_E_DsffQWX4_WiMQs2WRRNLzpyKiSKa4dycOixcpN80b4VmTJN8ErxZVA?width=309&height=440&cropmode=none)

![ChooseRepo](https://xjm8sg.by3302.livefilestore.com/y4mn4qT4JSPYP2wNGfabu2UEmxkq27qLEmCcdJWlBvTQIYpicg5PrbZX0f-dwBbiGXoxRldJ41BV84b9kK5D0xcVrOIvETBflQKYDYJCA7H85IrlVrAMcK4DfVdEcxu7oBVGfm6B9GsTxEbSeslS5nhQCDWC-KgVlT7Cdje_3YF8EFZ4CgZOiNdZEFOFsywH_LggFgnydZuAhoA7B582wAFjw?width=314&height=129&cropmode=none)

![Complete CD Options](https://wsqvqa.by3302.livefilestore.com/y4mDQSi7eDdwhjIt4RKY7aYtzOoVQivieutoR8oL9Awnpka_iH7ys5Q0NiVdQZ8Ik3PAi7KUvrRO-Kso8ljbpFJ_hkB0gEQX3vaN6nGwB20AZ1cj6hh5Kx926NjszmchPst-BRB-FNaTEmQrjikPf67rRdNIn5f0rgDUTu1XBusJTYnU7hWIg-4Y25OE25qaj6YUCs0uE2_rkH5SpqiIls8qw?width=313&height=519&cropmode=none)

![Deployment](https://8mybwa.by3302.livefilestore.com/y4m4pq0mh7gdXmva9q5dYEKnMb2lP8FXhrPfjSDpK3nHbpt2mxD35R0ZOAJp9zJdlCwaVWciSoAOrX5800m0VHXGCDU0Hr54h5xEln7AvQysaMOS7UqVAH4FQWEu-GvP41SGrFZoYYYm0rZ1GQ4f8Fu1_m4GDnRUavKSiLQjtk5_pzzzKZHsKfbMCouOL8qX6aWS2IL-lcj2U_f8UX_Hz-P-g?width=581&height=220&cropmode=none)

![First Test](https://jrbqbq.by3302.livefilestore.com/y4m_oIDkedjk90mS7uGCWzASAixCV2rzgN-qmr6dQo168PMcpTPgxcxHIZpJy9zaueegDniw1h7pVXuw9xrZGGgdgRdfPQJFQoI0ncnxE45QWU66A2gGYgOvy0CAzq6tWJoCa0Bvd9KWLkF-lORcW8M2fFy2Mf-BwZZKY4DdFIVOIRamUSQqGNChBDRRl5WBvQDwOqVKjhl4lF8IvEirK62aA?width=405&height=484&cropmode=none)

!! TODO !! Generate Access Token for GitHub and Authorize GitHub Workflow