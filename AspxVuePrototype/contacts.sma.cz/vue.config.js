module.exports = {
    filenameHashing: false,
    pages:
    {
        defaultPage: {
            entry: 'src/pages/default/defaultPage.js',
            title: 'Default Page'
        },
        personsPage: {
            entry: 'src/pages/person/personsPage.js',
            title: 'Persons Page'
        }
    },
    css: {
        extract: true
    }

}