import Vue from 'vue'
import App from './defaultPage.vue'


import '../../styles/custom.scss'


import { BootstrapVue } from 'bootstrap-vue';
Vue.use(BootstrapVue);


new Vue({
    render: h => h(App)
}).$mount('#DefaultPage');