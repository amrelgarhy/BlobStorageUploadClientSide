const path = require('path');

module.exports = {
    entry: './wwwroot/js/site.js',
    output: {
        path: path.resolve(__dirname, 'wwwroot/js/dist'),
        filename: 'fsAzureStorage-bundle.js',
        library: 'fsAzureBlobStorage',
        libraryTarget: 'umd'
    },
    mode: 'production'
};
