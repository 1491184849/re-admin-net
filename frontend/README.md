# Re-Admin

**概述：**

从0到1，基于vite+vue+elementPlus构建的前端框架。框架基于角色访问控制（RBAC），使用角色控制页面访问，使用指令或函数控制按钮显示与隐藏；目前还在开发中，诚邀感兴趣的开发者加入其中，为开源事业贡献力量。

**愿景：**

1. 能够让任何开发者都能快速开发；
2. 能够快速对接任何后端框架；
3. 保持初心，毫无保留，永远开源。

## 快速使用

**安装**

`yarn install`

**使用模拟数据**

`yarn run mock`

**预览图**

## 功能列表

* 通用对接
* 模拟数据
* 动态菜单
* 智能表格
* 权限hook
* 权限指令
* 页面权限
* 手写标签栏

### 手写标签栏

1. 首页固定，其余使用数组动态操作
2. 标签支持动态新增、删除、路由跳转
3. 关闭指定标签，要跳至上一个；数组第一个标签被关闭跳回首页
4. 根据屏幕宽度算出最大动态标签数
5. 数组标签超过可视范围，隐藏多余标签，支持点击左右方向按钮移动
6. 关闭当前、关闭左侧、关闭右侧、关闭其它、关闭全部
7. 刷新当前标签页

### 模拟数据

mock目录下自定模拟数据

### 动态菜单

...

## 待办事项

* 菜单搜索
* 常用组件封装
* 确定logo
* 修改登录页UI
* 无路由跳404页面