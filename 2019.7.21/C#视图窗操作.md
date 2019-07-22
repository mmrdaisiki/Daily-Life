# 演示Windows窗体应用程序的基本语法  
### 1.双击ch01.sln打开解决方案  
### 2.在【解决方案资源管理器】中，鼠标右击ch01，在弹出的快捷菜单中，选择【添加】→【新建项目】，在弹出的窗体中，选择【Windows窗体应用程序】模板，输入项目名``WinFormExample``s
### 3.在【解决方案资源管理器】中，鼠标右击``WinFormExample``，在弹出的快捷菜单中，选择【设为启动项目】
### 4.按``<F5>``键运行该项目，观察结果  
### 5. 鼠标右击``WinFormExamples``项目，在弹出的快捷菜单中，选择【添加】→【新建文件夹】，在该项目下新建一个名为``Forms``的文件夹
### 6. 鼠标右击``Forms``项目，在弹出的快捷菜单中，选择【添加】→【Windows窗体】，添加一个名为"HelloWorldForm.cs"的窗体，然后从【工具箱】中向该窗体拖放一个``Label``空间，并在【属性】窗口中观察改Label的【Name】属性值
### 7.将Label的Text属性值设置为``"Hello World"``
### 8.在“解决方案资源管理器”中，鼠标右击``Form1.cs``,选择【重命名】，将``Form1.cs``换名为``MainForm.cs``
### 9.在MainForm.cs，的设计模式下，向窗体拖放一个``Button``控件，在【属性】窗口中将其【Name】属性值修改为"ButtonHelloWorld",将【Text】属性值修改为"显示新窗体"，然后按照相同的办法，依次添加按钮
### 10.鼠标右击设计界面，选择【查看代码】，添加下面的命名空间引用：
```
using WinFormExamples.Forms;
```
### 11.在构造函数的``InitializeComponent();``语句的下面，添加语句设置主窗体的启动装置
```
 this.StartPosition = FormStartPosition.CenterParent;
```
#### 输入枚举类型的值时有一个小技巧：先输入``this.StartPosition =``，然后按空格键，系统就会自动弹出快捷菜单可选项，选择合适的选项，回车即可
#### 12.注册``Button``按钮的``Click``事件，注册方法为：先输入``ButtonHelloWorld.Click +=``，然后连按两次``<Tab>``键，就会自动得到下面的代码：
```
 public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            ButtonHelloWorld.Click += ButtonHelloWorld_Click1;
        }

        private void ButtonHelloWorld_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
```
### 13.鼠标右键单击``ButtonHelloWorld_Click``，选择【重构】→【重命名】，将其换名为``button_Click``
### 14.修改``button_Click``的事件处理程序，将代码改为下面的内容
```
void button_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Button BTN = sender as Button;
            Form fm = null;
            switch(BTN.Text)
            {
                case "显示新窗体":
                    fm = new HelloWorldForm();
                    break;
            }
            if (fm != null)
            {
                fm.Owner = this;
                fm.StartPosition = FormStartPosition.CenterParent;
                fm.ShowDialog(this);
            }
        }
```
***



