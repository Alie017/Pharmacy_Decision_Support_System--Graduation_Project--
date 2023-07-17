import React from 'react'
import styles from './Layout.module.css'
import authBg from '../../../assets/authBg.png'

export default function Layout({children}) {
  return (
		<div className={styles.container}>
			<div className={styles.background}>
				<img src={authBg} alt='background' />
        <div className={styles.overlay}></div>
			</div>
			<div className={styles.content}>{children}</div>
		</div>
	)
}
