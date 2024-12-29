#EmojiText
##修复了该 图文混排的部分Bug。

需要保证Text宽高超过文本渲染所需，不然渲染失败
emoji 测试类型为
~~~
<a type=emoji>1</a>
<a type=emoji>2</a>文本
<a type=emoji>AB</a>
<a type=emoji>AC</a>
<a type=emoji>AA</a>
<a type=emoji>AB</a>
测试
~~~
unity版本 2021.3.32f1

Fork 自工程 GText (Emoji, Hyperlink and Underline for UGUI)
