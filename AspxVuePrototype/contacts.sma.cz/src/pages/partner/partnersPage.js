import Vue from 'vue'
import App from './partnersPage.vue'

import '../../styles/custom.scss'

import { BootstrapVue } from 'bootstrap-vue';
Vue.use(BootstrapVue);

new Vue({
    render: h => h(App)
}).$mount('#PartnersPage');
