# mpt-k8s-DemoAppOpsta

mpt-k8s-DemoAppOpsta

## image

image : tirawatt/demo-app-opsta:latest \
container port : 8080

## usage

### file

- ListFile => retrun array of filepath in directory \
  /api/File/ListFile?path=xxx \
  ex => /api/File/ListFile?path=D:\tmp

```json
[
  "D:\\tmp\\file_1.txt",
  "D:\\tmp\\dir1\\file_1.txt",
  "D:\\tmp\\dir1\\file_2.txt"
]
```

- ReadFile \
  /api/File/ReadFile?path=xxx

- WriteFile \
  /api/File/WriteFile?path=xxx&contents=hello

### windows authen

- GetAccountId => return Active Directory account \
  /api/WindowsAuten/GetAccountId

```json
{
  "isAuthenticated": true,
  "name": "xxx\\yyy"
}
```
