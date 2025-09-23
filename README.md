# BackgroundKeyboard

# 关于本项目：



## 一、用处

            本项目为基于C#开发的后台按键监控项目，，用于在程序窗口处于后台时能够监听前台的按键，例如热键唤起、快捷操作等。

## 二、用法

### 1.仅设置钩子：

                        将项目中的`KeyBoardHook.cs`添加到您的项目，同时引用命名空间`using KeysBinding;`

```csharp


bool is_hooked=false;
private KeyEventHandler keyEventHandler;
private KeyboardHook hook = new KeyboardHook();

private void handleKey(object sender, KeyEventArgs e) {
    //处理获取到的热键
}
public void startListen() {
    if (is_hooked) return;//防止重复调用
    keyEventHandler = new KeyEventHandler(handleKey);//转为事件处理器
    hook.KeyDownEvent += keyEventHandler;//注册事件
    hook.Start();//打开钩子
}

public void stopListen() {
    if (!is_hooked) return;
    if (keyEventHandler != null) {
        hook.KeyDownEvent -= keyEventHandler;//解绑事件处理器
        keyEventHandler = null;
        hook.Stop();//解除钩子
    }
}                        
```

### 2.快捷事件绑定

                        将项目中的`KeyBoardHook.cs` `KeysBinding.cs`添加到您的项目，同时引用命名空间`using KeysBinding;`

```csharp

bool is_hooked=false;
private KeyEventHandler keyEventHandler;
private KeyboardHook hook = new KeyboardHook();
private KeysBinding keyBinding;

private void handleKey(object sender, KeyEventArgs e) {
    keyBinding.handleKeyFunction(Control.ModifierKeys, e.KeyCode);//通用事件注册处理器
}
public void startListen() {
    if (is_hooked) return;//防止重复调用
    this.keyBinding = new KeysBinding();//事件[注册、调用]处理器
    keyEventHandler = new KeyEventHandler(handleKey);//转为事件处理器
    hook.KeyDownEvent += keyEventHandler;//注册事件
    hook.Start();//打开钩子
}

public void stopListen() {
    if (!is_hooked) return;
    if (keyEventHandler != null) {
        hook.KeyDownEvent -= keyEventHandler;//解绑事件处理器
        keyEventHandler = null;
        hook.Stop();//解除钩子
    }
} 
```

### 3.用户事件自定义一站式解决方案：

                        将项目中的`KeyBoardHook.cs` `KeysBinding.cs` `KeyGridBinding.cs`添加到您的项目，同时引用命名空间`using KeysBinding;`

```csharp
private KeyGridBinding binding;
void init() { 
    binding = new KeyGridBinding(dataGridView1);
    //（dataGridView）：表格，共3列，分别为名称（text，建议用户不可编辑），
    //控制键（combo：[Shift、Ctrl、Alt、None表示不需要控制键]），可由用户选择
    //普通键（text，（ABC123等），该段会由程序自动检测用户按键绑定，建议禁止用户编辑
    binding.startListen();
    this.FormClosed += (s, e) => {
        binding.stopListen();
    };
    bind();
    binding.initGridData();//将注册的键组同步到表格
}

void bind() {
    //示例
    binding.bind("666", () => {
        MessageBox.Show("666");
    },Keys.Alt,Keys.NumPad6);

    binding.bind("777", () => {
        MessageBox.Show("777");
    }, Keys.Alt, Keys.NumPad7);
}
```