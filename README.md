# Json Log Viewer

## 畫面
![image](https://github.com/PinXian53/LogViewer/blob/main/image/v1.2.0.png)

## 功能
1. 可以在 config 資料夾內，自定解析設定檔 (.json)
2. 支援欄位 auto resize
3. 支援簡易搜尋功能
4. 支援進階搜尋功能 (C# DataTable RowFilter)

支援設定:
- ColumnName [String]: 顯示的欄位名稱
- JsonPath [String]: 資料路徑(用JsonPath語法)
- IsSeverity [Boolean]: 是否為嚴重性欄位，會根據等級決定文字顏色 (ERROR 紅色, WARN 橘色, INFO 黑色)
- Searchable [Boolean]: 簡易搜尋時，欄位是否被搜尋
- SpecialColumn [String]: 特殊欄位 (SerialNumber: 流水號)

example:
```
[
	{
		"ColumnName": "serialNumber",
		"JsonPath": null,
		"IsSeverity": false,
		"Searchable": false,
		"SpecialColumn": "SerialNumber"
	},
	{
		"ColumnName": "textPayload",
		"JsonPath": "$.textPayload",
		"IsSeverity": false,
		"Searchable": true,
		"SpecialColumn": null
	},
	{
		"ColumnName": "severity",
		"JsonPath": "$.severity",
		"IsSeverity": true,
		"Searchable": false,
		"SpecialColumn": null
	}
]
```

## 版本歷程

### v1.2.2
1. 修正 null exception

### v1.2.1
1. 修正查詢後資料行數不會更新問題

### v1.2.0
1. 增加欄位 auto resize
2. 增加顯示資料行數

### v1.1.0
1. 增加搜尋功能

### v1.0.0
1. json log viewer 基本功能