import preprocess from "svelte-preprocess";
import adapter from '@sveltejs/adapter-static';

const config = {
    kit: {
		adapter: adapter({ pages: 'dist/wwwroot', assets: 'dist/wwwroot' }),
		target: '#svelte',
        files: {
			assets: 'src/Presentation/assets',
			lib: 'src/Presentation/components',
			routes: 'src/Presentation/pages',
			template: 'src/Presentation/app.html'
		},
		vite: {
			server: {
				proxy: {
					'/api': {
						target: 'http://localhost:5000',
						changeOrigin: true
					}
				}
			}
		}
	},
    preprocess: [preprocess({
        postcss: true
    })]
};

export default config;
