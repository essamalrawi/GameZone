$.validator.addMethod('filesize', function (value, element, paramter) {
    var isValid = this.optional(element) || element.files[0].size <= paramter;
    return isValid;
});
