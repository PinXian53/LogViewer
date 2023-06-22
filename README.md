# LogViewer
Json Log Viewer


## 畫面
![image](https://github.com/PinXian53/LogViewer/blob/main/image/v1.0.0.png)

## 設定
可以在 config 資料夾內，自行加上解析設定檔 (.json)

支援設定:
- ColumnName [String]: 顯示的欄位名稱
- JsonPath [String]: 資料路徑(用JsonPath語法)
- IsSeverity [Boolean]: 是否為嚴重性欄位，會根據等級決定文字顏色 (ERROR 紅色, WARN 橘色, INFO 黑色)

example:
```
[
	{
		"ColumnName": "textPayload",
		"JsonPath": "$.textPayload",
		"IsSeverity": false
	},
	{
		"ColumnName": "severity",
		"JsonPath": "$.severity",
		"IsSeverity": true
	}
]
```

