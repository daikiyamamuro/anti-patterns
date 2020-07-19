## コーディングアンチパターン
コーディングにおけるアンチパターンを書いていきます。  
言語はC#を使っていきます。  

<br />





### 目次
- [フラグ引数](#FlagArgs)

<br />





<span id="FlagArgs"></span>
### フラグ引数

#### 実装例
- [呼び出し元](/src/AntiPatterns/FlagArgs/TestCaller.cs)
- [アンチパターン](/src/AntiPatterns/FlagArgs/AntiPattern.cs)
- [リファクタリング後](/src/AntiPatterns/FlagArgs/Refactored.cs)

#### Bad Point :(
- ひとつのクラス／メソッドにおいて複数のことをしている可能性が高い。  
  『Single Responsibility Principle： 単一責任の原則』に違反している。

- 呼び出し箇所を検索する場合、IDEの参照元検索だけでは不十分で、呼び出し箇所のコードも追わないといけない。  
  今後の実装コスト／テストコストが高くなる。

- 機能追加などにより複雑さが増しやすい。


<br />




