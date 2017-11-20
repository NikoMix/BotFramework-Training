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

![Azure Resource groups](https://lfezmg.by3302.livefilestore.com/y4mQB-65f5J0DjgHkEULxD5i3gdbuo87HJjlXfQYL41hb4R_LkLebGX1za-u78ctc4rbO1sCABmwAWUzITQofszKe2Qo1MbFOD6xW5OOxCkANiYY4GUlTfE7Bp2vQ-vKsb1KKW1dp-MlyXecFdiJUdtG8nHMILKJ2q4RaC0rwtA8Bf1uI3yjDeWG_mLjKUgyVl45qE76gcel92Fw81Gf_jZ2A?width=180&height=660&cropmode=none)

Now Azure will open the so called "Resource Groups"-Blade. You will experience, that whenever you "drill-down" into your Resources, new Blades will be stacked to the right of the current blade. This allows you to navigate up and down in your resource hiarchy. To create a new Resource Group simply click the Add Button on the top.

![Add Resource Group](https://ypadea.by3302.livefilestore.com/y4mneOX5sGZpKUJGP3lh7ApRAnUEjhaCjqN9zFVKCmA83UrRS_gTslD0ltgV9aFzmHQQHLpvwhLVdyVnNkNcqwSxgkq6XocoU6BU1JEr_9s8cFrgj7HbjjB0mbuM3j623TA7pQqfCL53bBeULCiWPkzbmClY6TSu4geiA0cBs2xfHjS8gXi3-5vyT5Y8DleUcNBPB0MbH_BWJGQ4CDfFf6I_g?width=660&height=211&cropmode=none)

